using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WildChat
{
    public partial class Form1 : Form
    {
        private Registration? reg;
        private Lobby? lobby;
        private PasswordChange? passwordChange;
        private FirstLogin? firstLogin;
        ErrorProvider errorProvider = new ErrorProvider();
        string constring = "Server=192.168.66.139;Database=user;Uid=root;Allow User Variables=True;Convert Zero Datetime=True;Allow Zero Datetime=True;SslMode=none";

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            Brush b = new LinearGradientBrush(gradient_rectangle, Color.Maroon, Color.Gold, 65f);

            graphics.FillRectangle(b, gradient_rectangle);
        }
        public Form1()
        {
            InitializeComponent();
            btn_login.BackColor = Color.FromArgb(168, 28, 7);
            btn_register.BackColor = Color.FromArgb(168, 28, 7);
            pbx_hidepass.BackColor = System.Drawing.Color.White;
            pbx_showpass.BackColor = System.Drawing.Color.White;
            pbx_user.BackColor = System.Drawing.Color.Transparent;
            pbx_password.BackColor = System.Drawing.Color.Transparent;
            lbl_userlogin.BackColor = System.Drawing.Color.Transparent;
            lnklbl_forgotpass.BackColor = System.Drawing.Color.Transparent;
            this.Paint += new PaintEventHandler(set_background);
            firstLogin = new FirstLogin();
        }
        private bool CheckFirstLogin(string username)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string query = "SELECT COUNT(*) FROM userdetails AS UD " +
                   "INNER JOIN login AS L ON UD.user_id = L.user_id " +
                   "WHERE L.username = @username";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            return count == 0;
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

        private void pbx_hidepass_MouseHover(object sender, EventArgs e)
        {
            this.tooltip.SetToolTip(this.pbx_hidepass, "Hide Password");
        }

        private void pbx_showpass_MouseHover(object sender, EventArgs e)
        {
            this.tooltip.SetToolTip(this.pbx_showpass, "Show Password");
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            this.tooltip.SetToolTip(this.btn_login, "Log in");
        }

        private void btn_register_MouseHover(object sender, EventArgs e)
        {
            this.tooltip.SetToolTip(this.btn_register, "Register");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            reg = new Registration();
            this.Hide();
            reg.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(tbx_password.Text.Trim()))
            {
                errorProvider.SetError(tbx_password, "Password cannot be empty!");
                return;
            }
            else
            {
                errorProvider.SetError(tbx_password, string.Empty);
            }

            try
            {
                string connstring = $"{constring}; Connection Timeout=60";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    string log = $"SELECT user_id, username FROM login WHERE username COLLATE utf8mb4_general_ci = '{tbx_username.Text}' AND password COLLATE utf8mb4_general_ci = '{tbx_password.Text}'";
                    MySqlCommand cmd = new MySqlCommand(log, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            reader.Read();
                            int userId = reader.GetInt32(0); // Retrieve user_id
                            string retrievedUsername = reader.GetString(1); // Retrieve username
                            bool isFirstLogin = CheckFirstLogin(retrievedUsername);
                            this.Hide();

                            if (isFirstLogin)
                            {
                                FirstLogin firstLoginForm = new FirstLogin();
                                firstLoginForm.username = retrievedUsername;
                                firstLoginForm.ShowDialog();
                            }
                            else
                            {
                                Lobby lobbyForm = new Lobby();
                                lobbyForm.username = retrievedUsername;
                                lobbyForm.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lnklbl_forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordChange = new PasswordChange();
            this.Hide();
            passwordChange.Show();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_capslockon.Visible = true;
            }
            else
            {
                lbl_capslockon.Visible = false;
            }
        }

        private void EnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btn_login_Click(sender, e);
            }
        }
    }
}