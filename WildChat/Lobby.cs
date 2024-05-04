using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Collections;

namespace WildChat
{
    public partial class Lobby : Form
    {
        private Form1? login;
        public string username { get; set; }
        string constring = "Server=192.168.66.139;Database=user;Uid=root;Allow User Variables=True;Convert Zero Datetime=True;Allow Zero Datetime=True;SslMode=none";

        private const int MinimumWidth = 82;
        private const int MaximumWidth = 250;
        private bool isSideBarExpanded = false;
        private readonly Image menuImageCollapsed = Properties.Resources.menu;
        private readonly Image menuImageExpanded = Properties.Resources.arrow_left;
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.Maroon, Color.Gold, 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void sidebar_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.Gold, Color.Maroon, 100f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void Circular_PictureBox()
        {
            userpic.Paint += pbx_Paint;
            userpic.Refresh();
            pbx_userpic.Paint += pbx_Paint;
            pbx_userpic.Refresh();
            pbx_chattinguser.Paint += pbx_Paint;
            pbx_chattinguser.Refresh();
        }
        private void pbx_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, userpic.Width, userpic.Height);
            userpic.Region = new Region(path);
            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(0, 0, pbx_userpic.Width, pbx_userpic.Height);
            pbx_userpic.Region = new Region(path1);
            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(0, 0, pbx_chattinguser.Width, pbx_chattinguser.Height);
            pbx_chattinguser.Region = new Region(path2);
        }
        public Lobby()
        {
            InitializeComponent();
            Circular_PictureBox();
            openFileDialog = new OpenFileDialog();

            DoubleBuffered = true;

            messageload = new System.Windows.Forms.Timer();
            messageload.Interval = 2000;
            messageload.Tick += messageload_Tick;
            messageload.Start();

            pnl_homepage.BringToFront();
            sidebar.BringToFront();
            sidebar.Width = MinimumWidth;
            menu.Image = menuImageCollapsed;
            this.Paint += new PaintEventHandler(set_background);
            sidebar.Paint += new PaintEventHandler(sidebar_background);
            Image home = Properties.Resources.home;
            Image messages = Properties.Resources.chat;
            Image settings = Properties.Resources.settings;
            Image about = Properties.Resources.about;
            Image send = Properties.Resources.send;
            Image exit = Properties.Resources.exit;
            Image delete = Properties.Resources.trash;
            Image upload = Properties.Resources.upload;
            this.btn_upload.Image = (Image)(new Bitmap(upload, new Size(25, 25)));
            this.btn_upload.ImageAlign = ContentAlignment.MiddleCenter;
            this.btn_deleteconvo.Image = (Image)(new Bitmap(delete, new Size(25, 25)));
            this.btn_deleteconvo.ImageAlign = ContentAlignment.MiddleCenter;
            this.btn_exit.Image = (Image)(new Bitmap(exit, new Size(30, 30)));
            this.btn_exit.ImageAlign = ContentAlignment.MiddleCenter;
            this.btn_send.Image = (Image)(new Bitmap(send, new Size(30, 30)));
            this.btn_send.ImageAlign = ContentAlignment.MiddleCenter;
            this.btn_home.Image = (Image)(new Bitmap(home, new Size(46, 46)));
            this.btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            this.btn_messages.Image = (Image)(new Bitmap(messages, new Size(46, 46)));
            this.btn_messages.ImageAlign = ContentAlignment.MiddleLeft;
            this.btn_settings.Image = (Image)(new Bitmap(settings, new Size(46, 46)));
            this.btn_settings.ImageAlign = ContentAlignment.MiddleLeft;
            this.btn_about.Image = (Image)(new Bitmap(about, new Size(46, 46)));
            this.btn_about.ImageAlign = ContentAlignment.MiddleLeft;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            sidebar.MinimumSize = new Size(MinimumWidth, ClientSize.Height);
            sidebar.MaximumSize = new Size(MaximumWidth, ClientSize.Height);
            flpnl_userlist.MinimumSize = new Size(pnl_userlist.Width, pnl_userlist.Height);
            flpnl_userlist.MaximumSize = new Size(pnl_userlist.Width, pnl_userlist.Height);

            int newX = this.ClientSize.Width - (pnl_currentuser.Width + 81);
            int newY = this.ClientSize.Height - (pnl_currentuser.Height + 3);
            pnl_currentuser.Location = new Point(newX, newY);

            flpnl_messagehistory.Height = this.ClientSize.Height - pnl_messagearea.Height - pnl_userinfo.Height;
            flpnl_messagehistory.Width = this.ClientSize.Width - sidebar.Width - pnl_userlist.Width;

            Invalidate();
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login = new Form1();
            this.Hide();
            login.Show();
        }

        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            LoadData();
            CurrentUser();
        }
        private void LoadData()
        {
            lbl_username.Text = username;
            MySqlConnection con = new MySqlConnection(constring);

            byte[] getimage = new byte[0];
            con.Open();
            string q = $"SELECT username, password FROM login WHERE username COLLATE utf8mb4_general_ci = '{lbl_username.Text}'";
            string i = $"SELECT * FROM userdetails WHERE user_id = (SELECT user_id FROM login WHERE username COLLATE utf8mb4_general_ci = '{lbl_username.Text}')";

            LoadNewMessageNotifications();
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();
            if (datareader.HasRows)
            {
                lbl_username.Text = datareader["username"].ToString();
                tbx_password.Text = datareader["password"].ToString();
            }
            con.Close();
            con.Open();
            MySqlCommand cmd1 = new MySqlCommand(i, con);
            MySqlDataReader datareader1 = cmd1.ExecuteReader();
            if (datareader1.HasRows && datareader1.Read())
            {
                tbx_firstname.Text = datareader1["firstname"].ToString();
                tbx_middlename.Text = datareader1["middlename"].ToString();
                tbx_lastname.Text = datareader1["lastname"].ToString();
                tbx_phonenumber.Text = datareader1["phonenumber"].ToString();
                byte[] images = (byte[])datareader1["userpic"];
                string lastname = tbx_lastname.Text;
                if (images == null)
                {
                    userpic.Image = null;
                }
                else
                {
                    MemoryStream me = new MemoryStream(images);
                    userpic.Image = Image.FromStream(me);
                }
            }
            con.Close();
        }
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void LoadNewMessageNotifications()
        {
            try
            {
                // Clear existing notifications
                flpnl_latestMessages.Controls.Clear();

                // Retrieve the sender's user picture and their latest message
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    string query = @"
                SELECT UserDetails.userpic, LatestMessages.message AS latest_message
                FROM UserDetails
                INNER JOIN (
                    SELECT CASE
                                WHEN userone = @currentUsername THEN usertwo
                                ELSE userone
                           END AS user_id,
                           message
                    FROM Chat
                    WHERE userone = @currentUsername OR usertwo = @currentUsername
                    ORDER BY MsgId DESC
                ) AS LatestMessages
                ON UserDetails.user_id = LatestMessages.user_id;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@currentUsername", lbl_currentuser.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Image userImage = ByteArrayToImage(reader["userpic"] as byte[]);
                                string latestMessage = reader.GetString("latest_message");

                                LatestMessageControl notification = new LatestMessageControl();
                                notification.Icon = userImage;
                                notification.Message = latestMessage;
                                notification.Click += (sender, e) =>
                                {
                                    pnl_messagespage.BringToFront();
                                    sidebar.BringToFront();
                                    userlist1_Click(sender, e);
                                };
                                flpnl_latestMessages.Controls.Add(notification);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    string delDetails = $"DELETE FROM userdetails WHERE user_id = (SELECT user_id FROM login WHERE username COLLATE utf8mb4_general_ci = '{lbl_username.Text}')";
                    MySqlCommand cmdDetails = new MySqlCommand(delDetails, con);
                    int rowsAffectedDetails = cmdDetails.ExecuteNonQuery();
                    string delLogin = $"DELETE FROM login WHERE username COLLATE utf8mb4_general_ci = '{lbl_username.Text}'";
                    MySqlCommand cmdLogin = new MySqlCommand(delLogin, con);
                    int rowsAffectedLogin = cmdLogin.ExecuteNonQuery();

                    con.Close();

                    if (rowsAffectedDetails > 0 && rowsAffectedLogin > 0)
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
        private void menu_Click(object sender, EventArgs e)
        {
            ToggleMenu();
        }

        private void ToggleMenu()
        {
            if (isSideBarExpanded)
            {
                CollapseSidebar();
            }
            else
            {
                ExpandSidebar();
            }
            isSideBarExpanded = !isSideBarExpanded;
            NavigationAccessibility(isSideBarExpanded);
        }

        private void CollapseSidebar()
        {
            timerSidebar.Start();
            menu.Image = menuImageCollapsed;
        }

        private void ExpandSidebar()
        {
            timerSidebar.Start();
            menu.Image = menuImageExpanded;
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (isSideBarExpanded)
            {
                if (sidebar.Width != MaximumWidth)
                {
                    sidebar.Width += 75;
                }
                else
                {
                    timerSidebar.Stop();
                }
            }
            else
            {
                if (sidebar.Width != MinimumWidth)
                {
                    sidebar.Width -= 75;
                }
                else
                {
                    timerSidebar.Stop();
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
                using (MemoryStream ms = new MemoryStream())
                {
                    userpic.Image.Save(ms, ImageFormat.Jpeg); // Save as JPEG format

                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        con.Open();
                        string getUserIdQuery = "SELECT user_id FROM login WHERE username = @username";
                        MySqlCommand getUserIdCmd = new MySqlCommand(getUserIdQuery, con);
                        getUserIdCmd.Parameters.AddWithValue("@username", username); // Assuming 'username' is accessible here
                        int userId = (int)getUserIdCmd.ExecuteScalar();

                        string updateQuery = "UPDATE userdetails " +
                                             "SET firstname = @firstname, middlename = @middlename, " +
                                             "lastname = @lastname, phonenumber = @phonenumber, userpic = @userpic " +
                                             "WHERE user_id = @user_id";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@user_id", userId);
                        updateCmd.Parameters.AddWithValue("@firstname", tbx_firstname.Text);
                        updateCmd.Parameters.AddWithValue("@middlename", tbx_middlename.Text);
                        updateCmd.Parameters.AddWithValue("@lastname", tbx_lastname.Text);
                        updateCmd.Parameters.AddWithValue("@phonenumber", tbx_phonenumber.Text);
                        updateCmd.Parameters.AddWithValue("@userpic", ms.ToArray());
                        updateCmd.ExecuteNonQuery();
                    }
                }
                CurrentUser();
                MessageBox.Show("User Details Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void userpic_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Select Image(*Jpg; *.png|*.Jpg; *.png";
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

        private void NavigationAccessibility(bool isExpanded)
        {
            btn_home.Enabled = isExpanded;
            btn_messages.Enabled = isExpanded;
            btn_settings.Enabled = isExpanded;
            btn_about.Enabled = isExpanded;
        }
        private void btn_account_Click(object sender, EventArgs e)
        {
            pnl_account.BringToFront();
            CollapseSidebar();
            sidebar.BringToFront();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            PasswordChange changepass = new PasswordChange();
            string username = lbl_username.Text;
            changepass.ChangePassFromSettings(username);
            changepass.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ToggleMenu();
            pnl_homepage.BringToFront();
            sidebar.BringToFront();
        }

        private void btn_messages_Click(object sender, EventArgs e)
        {
            UserItem();
            ToggleMenu();
            pnl_messagespage.BringToFront();
            sidebar.BringToFront();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            ToggleMenu();
            pnl_settingspage.BringToFront();
            sidebar.BringToFront();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            pnl_settingspage.BringToFront();
            sidebar.BringToFront();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application in development by Elwison Denampo." + Environment.NewLine + "Version 0.3", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UserItem()
        {
            flpnl_userlist.Controls.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM userdetails", constring);
            DataTable userDetailsTable = new DataTable();
            adapter.Fill(userDetailsTable);

            MySqlDataAdapter loginAdapter = new MySqlDataAdapter("SELECT user_id FROM login WHERE username = @username", constring);
            loginAdapter.SelectCommand.Parameters.AddWithValue("@username", username);
            DataTable loginTable = new DataTable();
            loginAdapter.Fill(loginTable);

            if (userDetailsTable != null && loginTable != null)
            {
                if (userDetailsTable.Rows.Count > 0 && loginTable.Rows.Count > 0)
                {
                    int loggedInUserId = (int)loginTable.Rows[0]["user_id"]; // Assuming user_id is of type int

                    foreach (DataRow row in userDetailsTable.Rows)
                    {
                        int userId = (int)row["user_id"]; // Assuming user_id is of type int
                        if (userId != loggedInUserId)
                        {
                            userlist userControl = new userlist();
                            userControl.Title = row["lastname"].ToString() + ", " + row["firstname"].ToString(); // Format name as "Lastname, Firstname"
                                                                                                                 // Assuming you have a column named 'userpic' that stores the user's picture as binary data
                            byte[] imageBytes = row["userpic"] as byte[];
                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    userControl.Icon = Image.FromStream(ms); // Set the user's picture
                                }
                            }
                            flpnl_userlist.Controls.Add(userControl);
                            userControl.Click += new System.EventHandler(this.userlist1_Click);
                        }
                    }
                }
            }
        }
        private void CurrentUser()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM userdetails WHERE user_id IN (SELECT user_id FROM login WHERE username = @username)", constring);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                byte[] imageBytes = row["userpic"] as byte[];
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbx_userpic.Image = Image.FromStream(ms); // Set the user's picture
                    }
                }
                string firstName = row["firstname"].ToString();
                string lastName = row["lastname"].ToString();
                lbl_currentuser.Text = $"{lastName}, {firstName}"; // Format name as "Lastname, Firstname"
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            flpnl_messagehistory.Controls.Clear();
            MySqlConnection con = new MySqlConnection(constring);
            string q = $"INSERT INTO chat(userone, usertwo, message) VALUES (@u1, @u2, @msg)";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Parameters.AddWithValue("u1", lbl_currentuser.Text);
            cmd.Parameters.AddWithValue("u2", lbl_chattinguser.Text);

            if (tbx_message.Tag is byte[] imageData)
            {
                cmd.Parameters.AddWithValue("msg", imageData);
            }
            else
            {
                cmd.Parameters.AddWithValue("msg", tbx_message.Text);
            }

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageChat();
            tbx_message.Clear();
        }
        private void MessageChat()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Chat", constring);
            DataTable table = new DataTable();
            adapter.Fill(table);

            flpnl_messagehistory.Controls.Clear(); // Clear existing message controls

            foreach (DataRow row in table.Rows)
            {
                if (lbl_currentuser.Text == row["userone"].ToString() && lbl_chattinguser.Text == row["usertwo"].ToString())
                {
                    SendMessage sendMessage = new SendMessage();
                    sendMessage.Dock = DockStyle.Right;
                    sendMessage.BringToFront();
                    sendMessage.Message = row["message"].ToString();
                    flpnl_messagehistory.Controls.Add(sendMessage);
                    flpnl_messagehistory.ScrollControlIntoView(sendMessage);
                }
                else if (lbl_chattinguser.Text == row["userone"].ToString() && lbl_currentuser.Text == row["usertwo"].ToString())
                {
                    ReceivedMessage receivedMessage = new ReceivedMessage();
                    receivedMessage.Dock = DockStyle.Left;
                    receivedMessage.BringToFront();
                    receivedMessage.Message = row["message"].ToString();
                    receivedMessage.Icon = pbx_chattinguser.Image; // Set the icon (profile picture) for the sender
                    flpnl_messagehistory.Controls.Add(receivedMessage);
                    flpnl_messagehistory.ScrollControlIntoView(receivedMessage);

                    MessageRead(row["MsgId"].ToString());
                }
            }
        }

        private void MessageRead(string messageId)
        {
            string q = $"UPDATE chat SET is_read = 1 WHERE MsgId = @id";
            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                using (MySqlCommand command = new MySqlCommand(q, connection))
                {
                    command.Parameters.AddWithValue("@id", messageId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void userlist1_Click(object sender, EventArgs e)
        {
            if (pnl_userinfo.Visible == false && pnl_messagearea.Visible == false && flpnl_messagehistory.Visible == false)
            {
                pnl_userinfo.Visible = true;
                pnl_messagearea.Visible = true;
                flpnl_messagehistory.Visible = true;
            }

            userlist users = (userlist)sender;
            lbl_chattinguser.Text = users.Title;
            pbx_chattinguser.Image = users.Icon;
            flpnl_messagehistory.Controls.Clear();
            flpnl_messagehistory.Refresh();
            MessageChat();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (pnl_userinfo.Visible == true && pnl_messagearea.Visible == true && flpnl_messagehistory.Visible == true)
            {
                pnl_userinfo.Visible = false;
                pnl_messagearea.Visible = false;
                flpnl_messagehistory.Visible = false;
            }
        }

        private void EnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btn_send_Click(sender, e);
            }
        }

        private void messageload_Tick(object sender, EventArgs e)
        {
            flpnl_messagehistory.SuspendLayout();
            flpnl_messagehistory.Controls.Clear(); flpnl_messagehistory.Refresh();
            MessageChat();
            flpnl_messagehistory.ResumeLayout();
        }

        private void btn_deleteconvo_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the conversation?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                DialogResult finalconfirm = MessageBox.Show("Are you really sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (finalconfirm == DialogResult.Yes)
                {
                    string del = $"DELETE FROM chat WHERE (userone = @currentUser AND usertwo = @chattingUser) OR (userone = @chattingUser AND usertwo = @currentUser)";

                    try
                    {
                        using (MySqlConnection con = new MySqlConnection(constring))
                        {
                            con.Open();
                            using (MySqlCommand cmd = new MySqlCommand(del, con))
                            {
                                cmd.Parameters.AddWithValue("@currentUser", lbl_currentuser.Text);
                                cmd.Parameters.AddWithValue("@chattingUser", lbl_chattinguser.Text);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Conversation deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    flpnl_messagehistory.Controls.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("No conversation found to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the conversation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private byte[] GetSelectedImageByteArrayFromFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    return File.ReadAllBytes(imagePath);
                }
            }
            return null; // Return null if no image is selected
        }

        private void flpnl_messagehistory_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string imagePath = files[0];
                    if (IsImageFile(imagePath))
                    {
                        byte[] imageByteArray = File.ReadAllBytes(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("Please drop an image file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private bool IsImageFile(string filePath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string extension = Path.GetExtension(filePath).ToLower();

            return imageExtensions.Contains(extension);
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            GetSelectedImageByteArrayFromFileDialog();
        }
    }
}