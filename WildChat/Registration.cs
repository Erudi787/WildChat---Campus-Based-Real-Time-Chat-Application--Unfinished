using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;
using System.Net;

namespace WildChat
{
    public partial class Registration : Form
    {
        private Form1? login;
        //string constring = "Data Source=ERUDI;Initial Catalog=User;Persist Security Info=True;User ID=USER;Password=***********;TrustServerCertificate=True";
        //string constring = "Data Source=ERUDI;Initial Catalog=Authentication;Integrated Security=True;Trust Server Certificate=True";
        //string constring = "Data Source=ERUDI;Initial Catalog=User;Integrated Security=True;";
        //string constring = "Data Source=ERUDI;Initial Catalog=User;User ID=USER;Password=***********";
        static string GetLocalIPv4()
        {
            string localIPv4 = "";
            foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIPv4 = ip.ToString();
                    break;
                }
            }
            return localIPv4;
        }

        //string constring = $"Server={GetLocalIPv4()};Database=user;Uid=root;Allow User Variables=True;Convert Zero Datetime=True;Allow Zero Datetime=True;SslMode=none";
        string constring = "Server=192.168.66.139;Database=user;Uid=root;Allow User Variables=True;Convert Zero Datetime=True;Allow Zero Datetime=True;SslMode=none";

        //string constring = "Server=localhost;Database=user;Uid=root";


        /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
        {
            TrustServerCertificate = true
        };*/
        ErrorProvider errorProvider = new ErrorProvider();

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.Maroon, Color.Gold, 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }
        public Registration()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login = new Form1();
            this.Hide();
            login.Show();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void pbx_showpass_Click(object sender, EventArgs e)
        {
            if (tbx_password.PasswordChar == '•')
            {
                pbx_hidepass.BringToFront();
                pbx_hidepass.Visible = true;
                tbx_password.PasswordChar = '\0';
            }
        }

        private void pbx_hidepass_Click(object sender, EventArgs e)
        {
            if (tbx_password.PasswordChar == '\0')
            {
                pbx_showpass.BringToFront();
                pbx_showpass.Visible = true;
                tbx_password.PasswordChar = '•';
            }
        }

        private void pbx_showconfirmpass_Click(object sender, EventArgs e)
        {
            if (tbx_confirmpassword.PasswordChar == '•')
            {
                pbx_hideconfirmpass.BringToFront();
                pbx_hideconfirmpass.Visible = true;
                tbx_confirmpassword.PasswordChar = '\0';
            }
        }

        private void pbx_hideconfirmpass_Click(object sender, EventArgs e)
        {
            if (tbx_confirmpassword.PasswordChar == '\0')
            {
                pbx_showconfirmpass.BringToFront();
                pbx_showconfirmpass.Visible = true;
                tbx_confirmpassword.PasswordChar = '•';
            }
        }

        /*private void btn_register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string ins = "INSERT INTO Login(username, password, confirm_password) VALUES" +
                "(@username, @password, @confirmpassword)";
            SqlCommand cmd = new SqlCommand(ins, con);
            //MemoryStream me = new MemoryStream(); //for images

            con.Open();
            string checkDuplicateQuery = $"SELECT COUNT(*) FROM Login WHERE username COLLATE utf8mb4_general_ci = @username";
            SqlCommand checkCmd = new SqlCommand(checkDuplicateQuery, con);
            checkCmd.Parameters.AddWithValue("@username", tbx_username.Text);
            int count = (int)checkCmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmd.Parameters.AddWithValue("username", tbx_username.Text);
            cmd.Parameters.AddWithValue("password", tbx_password.Text);
            cmd.Parameters.AddWithValue("confirmpassword", tbx_confirmpassword.Text);
            if (string.IsNullOrEmpty(tbx_username.Text.Trim()))
            {
                MessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(tbx_username, "Username cannot be empty!");
                return;
            }
            else
            {
                errorProvider.SetError(tbx_username, string.Empty);
            }

            if (string.IsNullOrEmpty(tbx_password.Text.Trim()))
            {
                MessageBox.Show("Please input a password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(tbx_password, "Password cannot be empty!");
                return;
            }
            else if (tbx_password.TextLength < 5)
            {
                MessageBox.Show("Password must contain more than 5 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                errorProvider.SetError(tbx_password, string.Empty);
            }

            if (string.IsNullOrEmpty(tbx_confirmpassword.Text.Trim()))
            {
                MessageBox.Show("Please confirm your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(tbx_confirmpassword, "Please confirm your password!");
                return;
            }
            else
            {
                errorProvider.SetError(tbx_confirmpassword, string.Empty);
            }

            if (tbx_password.Text != tbx_confirmpassword.Text)
            {
                lbl_passwordnotequal.Visible = true;
                errorProvider.SetError(tbx_confirmpassword, "Passwords do not match.");
                MessageBox.Show("Passwords do not match. Please re-enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registration Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            login = new Form1();
            this.Hide();
            login.Show();
        }*/
        private void btn_register_Click(object sender, EventArgs e)
        {
            // Check if username is empty
            if (string.IsNullOrEmpty(tbx_username.Text.Trim()))
            {
                MessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(tbx_username, "Username cannot be empty!");
                return;
            }
            else
            {
                errorProvider.SetError(tbx_username, string.Empty);
            }

            // Check if password is empty
            if (string.IsNullOrEmpty(tbx_password.Text.Trim()))
            {
                MessageBox.Show("Please input a password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(tbx_password, "Password cannot be empty!");
                return;
            }
            else if (tbx_password.TextLength < 5)
            {
                MessageBox.Show("Password must contain more than 5 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                errorProvider.SetError(tbx_password, string.Empty);
            }

            // Check if confirm password is empty
            if (string.IsNullOrEmpty(tbx_confirmpassword.Text.Trim()))
            {
                MessageBox.Show("Please confirm your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(tbx_confirmpassword, "Please confirm your password!");
                return;
            }
            else
            {
                errorProvider.SetError(tbx_confirmpassword, string.Empty);
            }

            // Check if passwords match
            if (tbx_password.Text != tbx_confirmpassword.Text)
            {
                lbl_passwordnotequal.Visible = true;
                errorProvider.SetError(tbx_confirmpassword, "Passwords do not match.");
                MessageBox.Show("Passwords do not match. Please re-enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username already exists
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string checkDuplicateQuery = "SELECT COUNT(*) FROM login WHERE username COLLATE utf8mb4_general_ci = @username";
            MySqlCommand checkCmd = new MySqlCommand(checkDuplicateQuery, con);
            checkCmd.Parameters.AddWithValue("@username", tbx_username.Text);
            //int count = (int)checkCmd.ExecuteScalar();
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert new user into database
            string ins = "INSERT INTO login(username, password, confirm_password) VALUES (@username, @password, @confirmpassword); SELECT LAST_INSERT_ID();";

            MySqlCommand cmd = new MySqlCommand(ins, con);
            cmd.Parameters.AddWithValue("@username", tbx_username.Text);
            cmd.Parameters.AddWithValue("@password", tbx_password.Text);
            cmd.Parameters.AddWithValue("@confirmpassword", tbx_confirmpassword.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // After successful registration, redirect to login form
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        private void tbx_password_Leave(object sender, EventArgs e)
        {
            if (tbx_password.TextLength < 5)
            {
                lbl_passwordweak.Visible = true;
                errorProvider.SetError(tbx_password, "Password must be more than 5 characters");
                return;
            }
            else
            {
                lbl_passwordweak.Visible = false;
                errorProvider.SetError(tbx_password, string.Empty);
            }
        }
        private void tbx_confirmpassword_Leave(object sender, EventArgs e)
        {
            if (tbx_password.Text != tbx_confirmpassword.Text)
            {
                lbl_passwordnotequal.Visible = true;
                errorProvider.SetError(tbx_confirmpassword, "Passwords do not match.");
                return;
            }
            else
            {
                lbl_passwordnotequal.Visible = false;
                errorProvider.SetError(tbx_confirmpassword, string.Empty);
            }
        }
        private void Registration_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_capslockon.Visible = true;
                lbl_capslockon1.Visible = true;
            }
            else
            {
                lbl_capslockon.Visible = false;
                lbl_capslockon1.Visible = false;
            }
        }
        private void EnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btn_register_Click(sender, e);
            }
        }
    }
}
