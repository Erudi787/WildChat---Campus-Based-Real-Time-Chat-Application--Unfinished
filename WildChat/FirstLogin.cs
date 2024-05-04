using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace WildChat
{
    public partial class FirstLogin : Form
    {
        private Form1? login;
        public string username { get; set; }

        string constring = "Server=192.168.66.139;Database=user;Uid=root;Allow User Variables=True;Convert Zero Datetime=True;Allow Zero Datetime=True;SslMode=none";

        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            Brush b = new LinearGradientBrush(gradient_rectangle, Color.Maroon, Color.Gold, 65f);

            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void Circular_PictureBox()
        {
            userpic.Paint += pbx_Paint;
            userpic.Refresh();
        }
        private void pbx_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, userpic.Width, userpic.Height);
            userpic.Region = new Region(path);
        }
        public FirstLogin()
        {
            InitializeComponent();
            Circular_PictureBox();
            openFileDialog = new OpenFileDialog();

            this.Paint += new PaintEventHandler(set_background);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                login = new Form1();
                this.Hide();
                login.Show();
            }
        }

        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void FirstLogin_Load(object sender, EventArgs e)
        {
            lbl_username.Text = username;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string q = $"SELECT username, password FROM login WHERE username COLLATE utf8mb4_general_ci = '{lbl_username.Text}'";
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();
            if (datareader.HasRows)
            {
                lbl_username.Text = datareader["username"].ToString();
            }
            con.Close();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure? This account will be deleted forever.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(constring);
                    con.Open();
                    string del = $"DELETE FROM Login WHERE username COLLATE utf8mb4_general_ci = '{lbl_username.Text}'";
                    MySqlCommand cmd = new MySqlCommand(del, con);
                    int rowAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowAffected > 0)
                    {
                        login = new Form1();
                        this.Hide();
                        login.Show();
                        MessageBox.Show("Account successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception at: {ex.Message}");
                }
            }

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (userpic.Image == null)
            {
                MessageBox.Show("Please upload an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Save the user details
                using (MemoryStream ms = new MemoryStream())
                {
                    // Save the image to the memory stream
                    userpic.Image.Save(ms, ImageFormat.Jpeg); // Save as JPEG format

                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        con.Open();

                        // Retrieve the user_id based on the username
                        string getUserIdQuery = "SELECT user_id FROM login WHERE username = @username";
                        MySqlCommand getUserIdCmd = new MySqlCommand(getUserIdQuery, con);
                        getUserIdCmd.Parameters.AddWithValue("@username", username); // Assuming 'username' is accessible here
                        int userId = (int)getUserIdCmd.ExecuteScalar();

                        // Insert the user details into the userdetails table
                        string insertQuery = "INSERT INTO userdetails (user_id, firstname, middlename, lastname, phonenumber, userpic) " +
                                             "VALUES (@user_id, @firstname, @middlename, @lastname, @phonenumber, @userpic)";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@user_id", userId);
                        insertCmd.Parameters.AddWithValue("@firstname", tbx_firstname.Text);
                        insertCmd.Parameters.AddWithValue("@middlename", tbx_middlename.Text);
                        insertCmd.Parameters.AddWithValue("@lastname", tbx_lastname.Text);
                        insertCmd.Parameters.AddWithValue("@phonenumber", tbx_phonenumber.Text);
                        insertCmd.Parameters.AddWithValue("@userpic", ms.ToArray());
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User Details Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Lobby lobby = new Lobby();
                lobby.username = username;
                lobby.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userpic_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Select Image(*Jpg; *.png|*.Jpg; *.png)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                userpic.Image = Image.FromFile(openFileDialog.FileName);
                Image pic = userpic.Image;
                CircularImage(pic);
            }
        }

        private void userpic_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            userpic.Refresh();
        }
        private void CircularImage(Image pic)
        {
            int diameter = Math.Min(userpic.Width, userpic.Height);
            Bitmap resizedImage = new Bitmap(diameter, diameter);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, diameter, diameter);
                g.SetClip(path);

                float scaleFactor = Math.Max((float)diameter / pic.Width, (float)diameter / pic.Height);
                int newWidth = (int)(pic.Width * scaleFactor);
                int newHeight = (int)(pic.Height * scaleFactor);
                int xOffset = (diameter - newWidth) / 2;
                int yOffset = (diameter - newHeight) / 2;

                g.DrawImage(pic, xOffset, yOffset, newWidth, newHeight);
            }
            userpic.Image = resizedImage;
            userpic.Refresh();
        }

        private bool firsttime = true;
        private void FirstLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (firsttime == true)
                {
                    this.Hide();
                    /*login = new Form1();
                    login.Show();*/
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
