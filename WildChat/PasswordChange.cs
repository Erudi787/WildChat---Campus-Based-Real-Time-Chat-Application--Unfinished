using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using MySql.Data.MySqlClient;

namespace WildChat
{
    public partial class PasswordChange : Form
    {
        private Form1? login;
        //string constring = "Data Source=ERUDI;Initial Catalog=User;Integrated Security=True;";
        //string constring = "Data Source=ERUDI;Initial Catalog=User;User ID=USER;Password=***********";
        //string constring = "Data Source=ERUDI;Initial Catalog=User;Persist Security Info=True;User ID=USER;Password=***********;TrustServerCertificate=True";
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

        //string constring = "Server=erudi;Database=user;Uid=erudi";

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
        private bool ChangedPassFromSettings = false;
        public void ChangePassFromSettings(string username)
        {
            tbx_username.Text = username;
            tbx_username.Enabled = false;
            pnl_changepass.BringToFront();
            ChangedPassFromSettings = true;
            ChangePass(username);
        }
        public PasswordChange()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            login = new Form1();
            this.Hide();
            login.Show();
        }

        private void PasswordChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (ChangedPassFromSettings == true)
                {
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
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
            string username = tbx_username.Text;
            ChangePass(username);
        }

        private void ChangePass(string username)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string log = $"SELECT * FROM login Where username COLLATE utf8mb4_general_ci = '{tbx_username.Text}'";
            MySqlCommand cmd = new MySqlCommand(log, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows != true)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (!reader.HasRows)
                    {
                        errorProvider.SetError(tbx_username, "Username does not exist.");
                        MessageBox.Show("Username does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else
                    {
                        tbx_username.Text = username;
                        tbx_username.Enabled = false;
                        pnl_changepass.BringToFront();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}");
                }
            }

            con.Close();
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

        private void btn_back1_Click(object sender, EventArgs e)
        {
            if (ChangedPassFromSettings == true)
            {
                this.Hide();
            }
            else
            {
                pnl_continue.BringToFront();
                tbx_username.Enabled = true;
                tbx_username.Text = null;
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

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(constring);
            string ins = "UPDATE login SET password = @password, confirm_password = @confirmpassword WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(ins, con);
            //MemoryStream me = new MemoryStream(); //for images

            cmd.Parameters.AddWithValue("username", tbx_username.Text);
            cmd.Parameters.AddWithValue("password", tbx_password.Text);
            cmd.Parameters.AddWithValue("confirmpassword", tbx_confirmpassword.Text);

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

            MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            if (ChangedPassFromSettings == false)
            {
                login = new Form1();
                login.Show();
            }
        }

        private void PasswordChange_KeyDown(object sender, KeyEventArgs e)
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
                btn_continue_Click(sender, e);
            }
        }

        private void EnterKey1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btn_changepass_Click(sender, e);
            }
        }
    }
}
