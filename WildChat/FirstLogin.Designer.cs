using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WildChat
{
    partial class FirstLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLogin));
            btn_save = new Button();
            tbx_phonenumber = new TextBox();
            lbl_phonenumber = new Label();
            tbx_lastname = new TextBox();
            tbx_middlename = new TextBox();
            tbx_firstname = new TextBox();
            lbl_lastname = new Label();
            lbl_middlename = new Label();
            lbl_firstname = new Label();
            btn_logout = new Button();
            userpic = new PictureBox();
            lbl_username = new Label();
            lbl_welcome = new Label();
            ((System.ComponentModel.ISupportInitialize)userpic).BeginInit();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_save.BackColor = Color.FromArgb(168, 28, 7);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(333, 351);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 46);
            btn_save.TabIndex = 35;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // tbx_phonenumber
            // 
            tbx_phonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbx_phonenumber.Location = new Point(278, 306);
            tbx_phonenumber.Name = "tbx_phonenumber";
            tbx_phonenumber.Size = new Size(262, 27);
            tbx_phonenumber.TabIndex = 31;
            // 
            // lbl_phonenumber
            // 
            lbl_phonenumber.Anchor = AnchorStyles.Top;
            lbl_phonenumber.AutoSize = true;
            lbl_phonenumber.BackColor = Color.Transparent;
            lbl_phonenumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_phonenumber.ForeColor = Color.White;
            lbl_phonenumber.Location = new Point(117, 305);
            lbl_phonenumber.Name = "lbl_phonenumber";
            lbl_phonenumber.Size = new Size(148, 28);
            lbl_phonenumber.TabIndex = 30;
            lbl_phonenumber.Text = "Phone Number:";
            // 
            // tbx_lastname
            // 
            tbx_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbx_lastname.Location = new Point(278, 268);
            tbx_lastname.Name = "tbx_lastname";
            tbx_lastname.Size = new Size(262, 27);
            tbx_lastname.TabIndex = 29;
            // 
            // tbx_middlename
            // 
            tbx_middlename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbx_middlename.Location = new Point(278, 226);
            tbx_middlename.Name = "tbx_middlename";
            tbx_middlename.Size = new Size(262, 27);
            tbx_middlename.TabIndex = 28;
            // 
            // tbx_firstname
            // 
            tbx_firstname.Location = new Point(278, 186);
            tbx_firstname.Name = "tbx_firstname";
            tbx_firstname.Size = new Size(262, 27);
            tbx_firstname.TabIndex = 27;
            // 
            // lbl_lastname
            // 
            lbl_lastname.Anchor = AnchorStyles.Top;
            lbl_lastname.AutoSize = true;
            lbl_lastname.BackColor = Color.Transparent;
            lbl_lastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lastname.ForeColor = Color.White;
            lbl_lastname.Location = new Point(117, 267);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(107, 28);
            lbl_lastname.TabIndex = 26;
            lbl_lastname.Text = "Last Name:";
            // 
            // lbl_middlename
            // 
            lbl_middlename.Anchor = AnchorStyles.Top;
            lbl_middlename.AutoSize = true;
            lbl_middlename.BackColor = Color.Transparent;
            lbl_middlename.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_middlename.ForeColor = Color.White;
            lbl_middlename.Location = new Point(117, 222);
            lbl_middlename.Name = "lbl_middlename";
            lbl_middlename.Size = new Size(135, 28);
            lbl_middlename.TabIndex = 25;
            lbl_middlename.Text = "Middle Name:";
            // 
            // lbl_firstname
            // 
            lbl_firstname.Anchor = AnchorStyles.Top;
            lbl_firstname.AutoSize = true;
            lbl_firstname.BackColor = Color.Transparent;
            lbl_firstname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_firstname.ForeColor = Color.White;
            lbl_firstname.Location = new Point(117, 182);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(110, 28);
            lbl_firstname.TabIndex = 24;
            lbl_firstname.Text = "First Name:";
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_logout.BackColor = Color.FromArgb(168, 28, 7);
            btn_logout.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(644, 506);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(138, 46);
            btn_logout.TabIndex = 19;
            btn_logout.Text = "BACK";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // userpic
            // 
            userpic.BackColor = Color.Transparent;
            userpic.Cursor = Cursors.Hand;
            userpic.Image = Properties.Resources.user2;
            userpic.Location = new Point(354, 44);
            userpic.Name = "userpic";
            userpic.Size = new Size(89, 97);
            userpic.SizeMode = PictureBoxSizeMode.Zoom;
            userpic.TabIndex = 23;
            userpic.TabStop = false;
            userpic.Click += userpic_Click;
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top;
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.Transparent;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(411, 13);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(60, 28);
            lbl_username.TabIndex = 21;
            lbl_username.Text = "{user}";
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.Top;
            lbl_welcome.AutoSize = true;
            lbl_welcome.BackColor = Color.Transparent;
            lbl_welcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_welcome.ForeColor = Color.White;
            lbl_welcome.Location = new Point(322, 13);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(97, 28);
            lbl_welcome.TabIndex = 20;
            lbl_welcome.Text = "Welcome,";
            // 
            // FirstLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(794, 564);
            Controls.Add(btn_save);
            Controls.Add(tbx_phonenumber);
            Controls.Add(lbl_phonenumber);
            Controls.Add(tbx_lastname);
            Controls.Add(tbx_middlename);
            Controls.Add(tbx_firstname);
            Controls.Add(lbl_lastname);
            Controls.Add(lbl_middlename);
            Controls.Add(lbl_firstname);
            Controls.Add(btn_logout);
            Controls.Add(userpic);
            Controls.Add(lbl_username);
            Controls.Add(lbl_welcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FirstLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Details";
            FormClosing += FirstLogin_FormClosing;
            Load += FirstLogin_Load;
            ((System.ComponentModel.ISupportInitialize)userpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_save;
        private TextBox tbx_phonenumber;
        private Label lbl_phonenumber;
        private TextBox tbx_lastname;
        private TextBox tbx_middlename;
        private TextBox tbx_firstname;
        private Label lbl_lastname;
        private Label lbl_middlename;
        private Label lbl_firstname;
        private Button btn_logout;
        private PictureBox userpic;
        private Label lbl_username;
        private Label lbl_welcome;
    }
}