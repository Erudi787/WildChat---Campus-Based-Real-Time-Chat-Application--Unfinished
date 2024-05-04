using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WildChat
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            btn_logout = new Button();
            lbl_welcome = new Label();
            lbl_username = new Label();
            btn_delete = new Button();
            userpic = new PictureBox();
            sidebar = new Panel();
            btn_settings = new Button();
            btn_about = new Button();
            btn_messages = new Button();
            btn_home = new Button();
            menu = new PictureBox();
            flpnl_messagehistory = new FlowLayoutPanel();
            sendMessage1 = new SendMessage();
            receivedMessage1 = new ReceivedMessage();
            timerSidebar = new System.Windows.Forms.Timer(components);
            pnl_account = new Panel();
            btn_back = new Button();
            pbx_showpass = new PictureBox();
            pbx_hidepass = new PictureBox();
            btn_save = new Button();
            btn_changepass = new Button();
            tbx_password = new TextBox();
            lbl_password = new Label();
            tbx_phonenumber = new TextBox();
            lbl_phonenumber = new Label();
            tbx_lastname = new TextBox();
            tbx_middlename = new TextBox();
            tbx_firstname = new TextBox();
            lbl_lastname = new Label();
            lbl_middlename = new Label();
            lbl_firstname = new Label();
            pnl_homepage = new Panel();
            flpnl_latestMessages = new FlowLayoutPanel();
            lbl_plan = new Label();
            pnl_settingspage = new Panel();
            lbl_settingspage = new Label();
            btn_account = new Button();
            pnl_messagespage = new Panel();
            pnl_userinfo = new Panel();
            btn_deleteconvo = new Button();
            btn_exit = new Button();
            lbl_chattinguser = new Label();
            pbx_chattinguser = new PictureBox();
            pnl_messagearea = new Panel();
            btn_upload = new Button();
            tbx_message = new TextBox();
            btn_send = new Button();
            pnl_currentuser = new Panel();
            lbl_currentuser = new Label();
            pbx_userpic = new PictureBox();
            pnl_userlist = new Panel();
            flpnl_userlist = new FlowLayoutPanel();
            userlist1 = new userlist();
            lbl_users = new Label();
            messageload = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)userpic).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            flpnl_messagehistory.SuspendLayout();
            pnl_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_showpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hidepass).BeginInit();
            pnl_homepage.SuspendLayout();
            pnl_settingspage.SuspendLayout();
            pnl_messagespage.SuspendLayout();
            pnl_userinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_chattinguser).BeginInit();
            pnl_messagearea.SuspendLayout();
            pnl_currentuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_userpic).BeginInit();
            pnl_userlist.SuspendLayout();
            flpnl_userlist.SuspendLayout();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_logout.BackColor = Color.FromArgb(168, 28, 7);
            btn_logout.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(647, 488);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(138, 46);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "LOG OUT";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.Top;
            lbl_welcome.AutoSize = true;
            lbl_welcome.BackColor = Color.Transparent;
            lbl_welcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_welcome.ForeColor = Color.White;
            lbl_welcome.Location = new Point(336, 8);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(97, 28);
            lbl_welcome.TabIndex = 1;
            lbl_welcome.Text = "Welcome,";
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top;
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.Transparent;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(425, 8);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(60, 28);
            lbl_username.TabIndex = 2;
            lbl_username.Text = "{user}";
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete.BackColor = Color.FromArgb(168, 28, 7);
            btn_delete.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(648, 505);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(151, 46);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "DELETE ACCOUNT";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // userpic
            // 
            userpic.Anchor = AnchorStyles.Top;
            userpic.BackColor = Color.Transparent;
            userpic.Cursor = Cursors.Hand;
            userpic.Image = Properties.Resources.user2;
            userpic.Location = new Point(368, 39);
            userpic.Name = "userpic";
            userpic.Size = new Size(89, 97);
            userpic.SizeMode = PictureBoxSizeMode.Zoom;
            userpic.TabIndex = 4;
            userpic.TabStop = false;
            userpic.LoadCompleted += userpic_LoadCompleted;
            userpic.Click += userpic_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Transparent;
            sidebar.Controls.Add(btn_settings);
            sidebar.Controls.Add(btn_about);
            sidebar.Controls.Add(btn_messages);
            sidebar.Controls.Add(btn_home);
            sidebar.Controls.Add(menu);
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(250, 563);
            sidebar.MinimumSize = new Size(82, 563);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(82, 563);
            sidebar.TabIndex = 6;
            // 
            // btn_settings
            // 
            btn_settings.BackColor = Color.Transparent;
            btn_settings.Enabled = false;
            btn_settings.FlatAppearance.BorderSize = 0;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_settings.Location = new Point(12, 376);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(225, 56);
            btn_settings.TabIndex = 17;
            btn_settings.Text = "Settings";
            btn_settings.UseVisualStyleBackColor = false;
            btn_settings.Click += btn_settings_Click;
            // 
            // btn_about
            // 
            btn_about.BackColor = Color.Transparent;
            btn_about.Enabled = false;
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_about.Location = new Point(12, 438);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(225, 56);
            btn_about.TabIndex = 18;
            btn_about.Text = "About";
            btn_about.UseVisualStyleBackColor = false;
            btn_about.Click += btn_about_Click;
            // 
            // btn_messages
            // 
            btn_messages.BackColor = Color.Transparent;
            btn_messages.Enabled = false;
            btn_messages.FlatAppearance.BorderSize = 0;
            btn_messages.FlatStyle = FlatStyle.Flat;
            btn_messages.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_messages.Location = new Point(12, 313);
            btn_messages.Name = "btn_messages";
            btn_messages.Size = new Size(225, 56);
            btn_messages.TabIndex = 16;
            btn_messages.Text = "Messages";
            btn_messages.UseVisualStyleBackColor = false;
            btn_messages.Click += btn_messages_Click;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.Transparent;
            btn_home.Enabled = false;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.Location = new Point(12, 252);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(225, 56);
            btn_home.TabIndex = 4;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // menu
            // 
            menu.Cursor = Cursors.Hand;
            menu.Image = Properties.Resources.menu;
            menu.Location = new Point(12, 12);
            menu.Name = "menu";
            menu.Size = new Size(56, 54);
            menu.SizeMode = PictureBoxSizeMode.Zoom;
            menu.TabIndex = 7;
            menu.TabStop = false;
            menu.Click += menu_Click;
            // 
            // flpnl_messagehistory
            // 
            flpnl_messagehistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpnl_messagehistory.AutoScroll = true;
            flpnl_messagehistory.BackColor = Color.Maroon;
            flpnl_messagehistory.Controls.Add(sendMessage1);
            flpnl_messagehistory.Controls.Add(receivedMessage1);
            flpnl_messagehistory.FlowDirection = FlowDirection.TopDown;
            flpnl_messagehistory.Location = new Point(0, 50);
            flpnl_messagehistory.Name = "flpnl_messagehistory";
            flpnl_messagehistory.Size = new Size(562, 460);
            flpnl_messagehistory.TabIndex = 6;
            flpnl_messagehistory.Visible = false;
            flpnl_messagehistory.WrapContents = false;
            flpnl_messagehistory.DragDrop += flpnl_messagehistory_DragDrop;
            // 
            // sendMessage1
            // 
            sendMessage1.BackColor = Color.Transparent;
            sendMessage1.Dock = DockStyle.Right;
            sendMessage1.Location = new Point(3, 3);
            sendMessage1.Message = null;
            sendMessage1.Name = "sendMessage1";
            sendMessage1.Size = new Size(551, 20);
            sendMessage1.TabIndex = 0;
            // 
            // receivedMessage1
            // 
            receivedMessage1.BackColor = Color.Transparent;
            receivedMessage1.Dock = DockStyle.Left;
            receivedMessage1.Icon = null;
            receivedMessage1.Location = new Point(3, 29);
            receivedMessage1.Message = null;
            receivedMessage1.Name = "receivedMessage1";
            receivedMessage1.Size = new Size(551, 20);
            receivedMessage1.TabIndex = 1;
            // 
            // timerSidebar
            // 
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // pnl_account
            // 
            pnl_account.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_account.BackColor = Color.Transparent;
            pnl_account.Controls.Add(btn_back);
            pnl_account.Controls.Add(pbx_showpass);
            pnl_account.Controls.Add(pbx_hidepass);
            pnl_account.Controls.Add(btn_save);
            pnl_account.Controls.Add(btn_changepass);
            pnl_account.Controls.Add(tbx_password);
            pnl_account.Controls.Add(lbl_password);
            pnl_account.Controls.Add(tbx_phonenumber);
            pnl_account.Controls.Add(lbl_phonenumber);
            pnl_account.Controls.Add(tbx_lastname);
            pnl_account.Controls.Add(tbx_middlename);
            pnl_account.Controls.Add(tbx_firstname);
            pnl_account.Controls.Add(lbl_lastname);
            pnl_account.Controls.Add(lbl_middlename);
            pnl_account.Controls.Add(lbl_firstname);
            pnl_account.Controls.Add(userpic);
            pnl_account.Controls.Add(btn_delete);
            pnl_account.Controls.Add(lbl_username);
            pnl_account.Controls.Add(lbl_welcome);
            pnl_account.Location = new Point(82, 1);
            pnl_account.Name = "pnl_account";
            pnl_account.Size = new Size(812, 561);
            pnl_account.TabIndex = 7;
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_back.BackColor = Color.FromArgb(168, 28, 7);
            btn_back.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(6, 505);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(151, 46);
            btn_back.TabIndex = 19;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // pbx_showpass
            // 
            pbx_showpass.AccessibleDescription = "";
            pbx_showpass.Anchor = AnchorStyles.Top;
            pbx_showpass.BackColor = SystemColors.ButtonFace;
            pbx_showpass.Cursor = Cursors.Hand;
            pbx_showpass.Image = Properties.Resources.hide_password;
            pbx_showpass.Location = new Point(528, 343);
            pbx_showpass.Name = "pbx_showpass";
            pbx_showpass.Size = new Size(25, 22);
            pbx_showpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_showpass.TabIndex = 17;
            pbx_showpass.TabStop = false;
            pbx_showpass.Click += pbx_showpass_Click;
            // 
            // pbx_hidepass
            // 
            pbx_hidepass.AccessibleDescription = "";
            pbx_hidepass.Anchor = AnchorStyles.Top;
            pbx_hidepass.BackColor = SystemColors.ButtonFace;
            pbx_hidepass.Cursor = Cursors.Hand;
            pbx_hidepass.Image = Properties.Resources.show_password;
            pbx_hidepass.Location = new Point(528, 343);
            pbx_hidepass.Name = "pbx_hidepass";
            pbx_hidepass.Size = new Size(25, 22);
            pbx_hidepass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_hidepass.TabIndex = 18;
            pbx_hidepass.TabStop = false;
            pbx_hidepass.Tag = "";
            pbx_hidepass.Click += pbx_hidepass_Click;
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Top;
            btn_save.BackColor = Color.FromArgb(168, 28, 7);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(356, 381);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 46);
            btn_save.TabIndex = 16;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_changepass
            // 
            btn_changepass.Anchor = AnchorStyles.Top;
            btn_changepass.BackColor = Color.FromArgb(168, 28, 7);
            btn_changepass.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_changepass.FlatStyle = FlatStyle.Flat;
            btn_changepass.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_changepass.ForeColor = Color.White;
            btn_changepass.Location = new Point(560, 341);
            btn_changepass.Name = "btn_changepass";
            btn_changepass.Size = new Size(157, 27);
            btn_changepass.TabIndex = 15;
            btn_changepass.Text = "CHANGE PASSWORD";
            btn_changepass.UseVisualStyleBackColor = false;
            btn_changepass.Click += btn_changepass_Click;
            // 
            // tbx_password
            // 
            tbx_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbx_password.Enabled = false;
            tbx_password.Location = new Point(292, 341);
            tbx_password.Name = "tbx_password";
            tbx_password.PasswordChar = '•';
            tbx_password.Size = new Size(262, 27);
            tbx_password.TabIndex = 14;
            // 
            // lbl_password
            // 
            lbl_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.Transparent;
            lbl_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.White;
            lbl_password.Location = new Point(131, 341);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(97, 28);
            lbl_password.TabIndex = 13;
            lbl_password.Text = "Password:";
            // 
            // tbx_phonenumber
            // 
            tbx_phonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbx_phonenumber.Location = new Point(292, 301);
            tbx_phonenumber.Name = "tbx_phonenumber";
            tbx_phonenumber.Size = new Size(262, 27);
            tbx_phonenumber.TabIndex = 12;
            // 
            // lbl_phonenumber
            // 
            lbl_phonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_phonenumber.AutoSize = true;
            lbl_phonenumber.BackColor = Color.Transparent;
            lbl_phonenumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_phonenumber.ForeColor = Color.White;
            lbl_phonenumber.Location = new Point(131, 300);
            lbl_phonenumber.Name = "lbl_phonenumber";
            lbl_phonenumber.Size = new Size(148, 28);
            lbl_phonenumber.TabIndex = 11;
            lbl_phonenumber.Text = "Phone Number:";
            // 
            // tbx_lastname
            // 
            tbx_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbx_lastname.Location = new Point(292, 263);
            tbx_lastname.Name = "tbx_lastname";
            tbx_lastname.Size = new Size(262, 27);
            tbx_lastname.TabIndex = 10;
            // 
            // tbx_middlename
            // 
            tbx_middlename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbx_middlename.Location = new Point(292, 221);
            tbx_middlename.Name = "tbx_middlename";
            tbx_middlename.Size = new Size(262, 27);
            tbx_middlename.TabIndex = 9;
            // 
            // tbx_firstname
            // 
            tbx_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbx_firstname.Location = new Point(292, 181);
            tbx_firstname.Name = "tbx_firstname";
            tbx_firstname.Size = new Size(262, 27);
            tbx_firstname.TabIndex = 8;
            // 
            // lbl_lastname
            // 
            lbl_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_lastname.AutoSize = true;
            lbl_lastname.BackColor = Color.Transparent;
            lbl_lastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lastname.ForeColor = Color.White;
            lbl_lastname.Location = new Point(131, 262);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(107, 28);
            lbl_lastname.TabIndex = 7;
            lbl_lastname.Text = "Last Name:";
            // 
            // lbl_middlename
            // 
            lbl_middlename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_middlename.AutoSize = true;
            lbl_middlename.BackColor = Color.Transparent;
            lbl_middlename.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_middlename.ForeColor = Color.White;
            lbl_middlename.Location = new Point(131, 217);
            lbl_middlename.Name = "lbl_middlename";
            lbl_middlename.Size = new Size(135, 28);
            lbl_middlename.TabIndex = 6;
            lbl_middlename.Text = "Middle Name:";
            // 
            // lbl_firstname
            // 
            lbl_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_firstname.AutoSize = true;
            lbl_firstname.BackColor = Color.Transparent;
            lbl_firstname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_firstname.ForeColor = Color.White;
            lbl_firstname.Location = new Point(131, 177);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(110, 28);
            lbl_firstname.TabIndex = 5;
            lbl_firstname.Text = "First Name:";
            // 
            // pnl_homepage
            // 
            pnl_homepage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_homepage.BackColor = Color.Transparent;
            pnl_homepage.Controls.Add(flpnl_latestMessages);
            pnl_homepage.Controls.Add(lbl_plan);
            pnl_homepage.Location = new Point(82, 1);
            pnl_homepage.Name = "pnl_homepage";
            pnl_homepage.Size = new Size(812, 561);
            pnl_homepage.TabIndex = 8;
            // 
            // flpnl_latestMessages
            // 
            flpnl_latestMessages.Location = new Point(0, 56);
            flpnl_latestMessages.Name = "flpnl_latestMessages";
            flpnl_latestMessages.Size = new Size(641, 506);
            flpnl_latestMessages.TabIndex = 4;
            // 
            // lbl_plan
            // 
            lbl_plan.AutoSize = true;
            lbl_plan.BackColor = Color.Transparent;
            lbl_plan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_plan.ForeColor = Color.White;
            lbl_plan.Location = new Point(16, 19);
            lbl_plan.Name = "lbl_plan";
            lbl_plan.Size = new Size(332, 28);
            lbl_plan.TabIndex = 3;
            lbl_plan.Text = "Home (message notif appear here)";
            // 
            // pnl_settingspage
            // 
            pnl_settingspage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_settingspage.BackColor = Color.Transparent;
            pnl_settingspage.Controls.Add(lbl_settingspage);
            pnl_settingspage.Controls.Add(btn_account);
            pnl_settingspage.Controls.Add(btn_logout);
            pnl_settingspage.Location = new Point(82, 1);
            pnl_settingspage.Name = "pnl_settingspage";
            pnl_settingspage.Size = new Size(812, 561);
            pnl_settingspage.TabIndex = 9;
            // 
            // lbl_settingspage
            // 
            lbl_settingspage.AutoSize = true;
            lbl_settingspage.BackColor = Color.Transparent;
            lbl_settingspage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_settingspage.ForeColor = Color.White;
            lbl_settingspage.Location = new Point(30, 7);
            lbl_settingspage.Name = "lbl_settingspage";
            lbl_settingspage.Size = new Size(101, 28);
            lbl_settingspage.TabIndex = 2;
            lbl_settingspage.Text = "SETTINGS";
            // 
            // btn_account
            // 
            btn_account.BackColor = Color.FromArgb(168, 28, 7);
            btn_account.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_account.FlatStyle = FlatStyle.Flat;
            btn_account.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_account.ForeColor = Color.White;
            btn_account.Location = new Point(30, 48);
            btn_account.Name = "btn_account";
            btn_account.Size = new Size(138, 46);
            btn_account.TabIndex = 1;
            btn_account.Text = "ACCOUNT";
            btn_account.UseVisualStyleBackColor = false;
            btn_account.Click += btn_account_Click;
            // 
            // pnl_messagespage
            // 
            pnl_messagespage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_messagespage.BackColor = Color.Transparent;
            pnl_messagespage.Controls.Add(pnl_userinfo);
            pnl_messagespage.Controls.Add(flpnl_messagehistory);
            pnl_messagespage.Controls.Add(pnl_messagearea);
            pnl_messagespage.Controls.Add(pnl_currentuser);
            pnl_messagespage.Controls.Add(pnl_userlist);
            pnl_messagespage.Location = new Point(82, 1);
            pnl_messagespage.Name = "pnl_messagespage";
            pnl_messagespage.Size = new Size(812, 561);
            pnl_messagespage.TabIndex = 9;
            // 
            // pnl_userinfo
            // 
            pnl_userinfo.BorderStyle = BorderStyle.FixedSingle;
            pnl_userinfo.Controls.Add(btn_deleteconvo);
            pnl_userinfo.Controls.Add(btn_exit);
            pnl_userinfo.Controls.Add(lbl_chattinguser);
            pnl_userinfo.Controls.Add(pbx_chattinguser);
            pnl_userinfo.Dock = DockStyle.Top;
            pnl_userinfo.Location = new Point(0, 0);
            pnl_userinfo.Name = "pnl_userinfo";
            pnl_userinfo.Size = new Size(562, 50);
            pnl_userinfo.TabIndex = 7;
            pnl_userinfo.Visible = false;
            // 
            // btn_deleteconvo
            // 
            btn_deleteconvo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_deleteconvo.FlatAppearance.BorderSize = 0;
            btn_deleteconvo.FlatStyle = FlatStyle.Flat;
            btn_deleteconvo.Location = new Point(475, 10);
            btn_deleteconvo.Name = "btn_deleteconvo";
            btn_deleteconvo.Size = new Size(30, 30);
            btn_deleteconvo.TabIndex = 5;
            btn_deleteconvo.UseVisualStyleBackColor = true;
            btn_deleteconvo.Click += btn_deleteconvo_Click;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Location = new Point(518, 10);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(30, 30);
            btn_exit.TabIndex = 4;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_chattinguser
            // 
            lbl_chattinguser.AutoSize = true;
            lbl_chattinguser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_chattinguser.ForeColor = Color.White;
            lbl_chattinguser.Location = new Point(61, 15);
            lbl_chattinguser.Name = "lbl_chattinguser";
            lbl_chattinguser.Size = new Size(48, 20);
            lbl_chattinguser.TabIndex = 3;
            lbl_chattinguser.Text = "{user}";
            // 
            // pbx_chattinguser
            // 
            pbx_chattinguser.BackColor = SystemColors.ControlDark;
            pbx_chattinguser.Location = new Point(15, 4);
            pbx_chattinguser.Name = "pbx_chattinguser";
            pbx_chattinguser.Size = new Size(40, 40);
            pbx_chattinguser.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_chattinguser.TabIndex = 2;
            pbx_chattinguser.TabStop = false;
            // 
            // pnl_messagearea
            // 
            pnl_messagearea.BorderStyle = BorderStyle.FixedSingle;
            pnl_messagearea.Controls.Add(btn_upload);
            pnl_messagearea.Controls.Add(tbx_message);
            pnl_messagearea.Controls.Add(btn_send);
            pnl_messagearea.Dock = DockStyle.Bottom;
            pnl_messagearea.Location = new Point(0, 505);
            pnl_messagearea.Name = "pnl_messagearea";
            pnl_messagearea.Size = new Size(562, 56);
            pnl_messagearea.TabIndex = 8;
            pnl_messagearea.Visible = false;
            // 
            // btn_upload
            // 
            btn_upload.Anchor = AnchorStyles.Right;
            btn_upload.BackColor = SystemColors.Window;
            btn_upload.FlatAppearance.BorderSize = 0;
            btn_upload.FlatStyle = FlatStyle.Flat;
            btn_upload.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_upload.Location = new Point(456, 16);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(25, 25);
            btn_upload.TabIndex = 6;
            btn_upload.UseVisualStyleBackColor = false;
            btn_upload.Click += btn_upload_Click;
            // 
            // tbx_message
            // 
            tbx_message.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbx_message.Location = new Point(16, 16);
            tbx_message.Name = "tbx_message";
            tbx_message.PlaceholderText = "  Type Here";
            tbx_message.Size = new Size(469, 27);
            tbx_message.TabIndex = 0;
            tbx_message.KeyPress += EnterKey;
            // 
            // btn_send
            // 
            btn_send.Anchor = AnchorStyles.Right;
            btn_send.BackColor = Color.Transparent;
            btn_send.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_send.Location = new Point(507, 6);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(45, 45);
            btn_send.TabIndex = 5;
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // pnl_currentuser
            // 
            pnl_currentuser.Anchor = AnchorStyles.None;
            pnl_currentuser.BorderStyle = BorderStyle.FixedSingle;
            pnl_currentuser.Controls.Add(lbl_currentuser);
            pnl_currentuser.Controls.Add(pbx_userpic);
            pnl_currentuser.Location = new Point(563, 505);
            pnl_currentuser.Name = "pnl_currentuser";
            pnl_currentuser.Size = new Size(249, 57);
            pnl_currentuser.TabIndex = 5;
            // 
            // lbl_currentuser
            // 
            lbl_currentuser.AutoSize = true;
            lbl_currentuser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentuser.ForeColor = Color.White;
            lbl_currentuser.Location = new Point(60, 19);
            lbl_currentuser.Name = "lbl_currentuser";
            lbl_currentuser.Size = new Size(104, 20);
            lbl_currentuser.TabIndex = 3;
            lbl_currentuser.Text = "{current_user}";
            // 
            // pbx_userpic
            // 
            pbx_userpic.BackColor = SystemColors.ControlDark;
            pbx_userpic.Location = new Point(14, 8);
            pbx_userpic.Name = "pbx_userpic";
            pbx_userpic.Size = new Size(40, 40);
            pbx_userpic.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_userpic.TabIndex = 2;
            pbx_userpic.TabStop = false;
            // 
            // pnl_userlist
            // 
            pnl_userlist.BorderStyle = BorderStyle.FixedSingle;
            pnl_userlist.Controls.Add(flpnl_userlist);
            pnl_userlist.Controls.Add(lbl_users);
            pnl_userlist.Dock = DockStyle.Right;
            pnl_userlist.Location = new Point(562, 0);
            pnl_userlist.Name = "pnl_userlist";
            pnl_userlist.Size = new Size(250, 561);
            pnl_userlist.TabIndex = 4;
            // 
            // flpnl_userlist
            // 
            flpnl_userlist.BorderStyle = BorderStyle.FixedSingle;
            flpnl_userlist.Controls.Add(userlist1);
            flpnl_userlist.Location = new Point(0, 48);
            flpnl_userlist.Name = "flpnl_userlist";
            flpnl_userlist.Size = new Size(250, 459);
            flpnl_userlist.TabIndex = 1;
            // 
            // userlist1
            // 
            userlist1.BackColor = Color.Transparent;
            userlist1.Icon = null;
            userlist1.Location = new Point(3, 3);
            userlist1.Name = "userlist1";
            userlist1.Size = new Size(247, 58);
            userlist1.TabIndex = 0;
            userlist1.Title = null;
            userlist1.Click += userlist1_Click;
            // 
            // lbl_users
            // 
            lbl_users.AutoSize = true;
            lbl_users.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_users.ForeColor = Color.White;
            lbl_users.Location = new Point(23, 8);
            lbl_users.Name = "lbl_users";
            lbl_users.Size = new Size(164, 28);
            lbl_users.TabIndex = 0;
            lbl_users.Text = "Registered Users";
            // 
            // messageload
            // 
            messageload.Tick += messageload_Tick;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(893, 564);
            Controls.Add(sidebar);
            Controls.Add(pnl_messagespage);
            Controls.Add(pnl_homepage);
            Controls.Add(pnl_account);
            Controls.Add(pnl_settingspage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(911, 611);
            Name = "Lobby";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lobby";
            FormClosing += Lobby_FormClosing;
            Load += Lobby_Load;
            ((System.ComponentModel.ISupportInitialize)userpic).EndInit();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            flpnl_messagehistory.ResumeLayout(false);
            pnl_account.ResumeLayout(false);
            pnl_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_showpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hidepass).EndInit();
            pnl_homepage.ResumeLayout(false);
            pnl_homepage.PerformLayout();
            pnl_settingspage.ResumeLayout(false);
            pnl_settingspage.PerformLayout();
            pnl_messagespage.ResumeLayout(false);
            pnl_userinfo.ResumeLayout(false);
            pnl_userinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_chattinguser).EndInit();
            pnl_messagearea.ResumeLayout(false);
            pnl_messagearea.PerformLayout();
            pnl_currentuser.ResumeLayout(false);
            pnl_currentuser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_userpic).EndInit();
            pnl_userlist.ResumeLayout(false);
            pnl_userlist.PerformLayout();
            flpnl_userlist.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_logout;
        private Label lbl_welcome;
        private Label lbl_username;
        private Button btn_delete;
        private PictureBox userpic;
        private Panel sidebar;
        private PictureBox menu;
        private System.Windows.Forms.Timer timerSidebar;
        private Panel pnl_account;
        private Label lbl_lastname;
        private Label lbl_middlename;
        private Label lbl_firstname;
        private TextBox tbx_middlename;
        private TextBox tbx_firstname;
        private TextBox tbx_lastname;
        private TextBox tbx_phonenumber;
        private Label lbl_phonenumber;
        private TextBox tbx_password;
        private Label lbl_password;
        private Button btn_changepass;
        private Button btn_save;
        private PictureBox pbx_showpass;
        private PictureBox pbx_hidepass;
        private Panel pnl_homepage;
        private Panel pnl_settingspage;
        private Button btn_account;
        private Label lbl_settingspage;
        private Label lbl_plan;
        private Button btn_home;
        private Button btn_messages;
        private Button btn_about;
        private Button btn_settings;
        private Button btn_back;
        private Panel pnl_messagespage;
        private Panel pnl_userlist;
        private Label lbl_users;
        private FlowLayoutPanel flpnl_userlist;
        private userlist userlist1;
        private Panel pnl_currentuser;
        private Label lbl_currentuser;
        private PictureBox pbx_userpic;
        private Panel pnl_userinfo;
        private FlowLayoutPanel flpnl_messagehistory;
        private Label lbl_chattinguser;
        private PictureBox pbx_chattinguser;
        private Panel pnl_messagearea;
        private TextBox tbx_message;
        private Button btn_send;
        private Button btn_exit;
        private SendMessage sendMessage1;
        private ReceivedMessage receivedMessage1;
        private FlowLayoutPanel flpnl_latestMessages;
        private System.Windows.Forms.Timer messageload;
        private Button btn_deleteconvo;
        private Button btn_upload;
    }
}