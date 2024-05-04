using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WildChat
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            pbx_showpass = new PictureBox();
            pbx_password = new PictureBox();
            pbx_user = new PictureBox();
            btn_register = new Button();
            btn_login = new Button();
            tbx_username = new TextBox();
            lbl_userregistration = new Label();
            pbx_hidepass = new PictureBox();
            tbx_password = new TextBox();
            pbx_showconfirmpass = new PictureBox();
            pbx_confirmpass = new PictureBox();
            pbx_hideconfirmpass = new PictureBox();
            tbx_confirmpassword = new TextBox();
            lbl_haveaccount = new Label();
            lbl_passwordweak = new Label();
            lbl_passwordnotequal = new Label();
            lbl_capslockon = new Label();
            lbl_capslockon1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_showpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hidepass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_showconfirmpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_confirmpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hideconfirmpass).BeginInit();
            SuspendLayout();
            // 
            // pbx_showpass
            // 
            pbx_showpass.AccessibleDescription = "";
            pbx_showpass.Anchor = AnchorStyles.Top;
            pbx_showpass.BackColor = Color.White;
            pbx_showpass.Cursor = Cursors.Hand;
            pbx_showpass.Image = Properties.Resources.hide_password;
            pbx_showpass.Location = new Point(335, 264);
            pbx_showpass.Name = "pbx_showpass";
            pbx_showpass.Size = new Size(25, 22);
            pbx_showpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_showpass.TabIndex = 20;
            pbx_showpass.TabStop = false;
            pbx_showpass.Click += pbx_showpass_Click;
            // 
            // pbx_password
            // 
            pbx_password.Anchor = AnchorStyles.Top;
            pbx_password.BackColor = Color.Transparent;
            pbx_password.Image = Properties.Resources.lock_png_icon_0;
            pbx_password.Location = new Point(89, 261);
            pbx_password.Name = "pbx_password";
            pbx_password.Size = new Size(25, 27);
            pbx_password.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_password.TabIndex = 19;
            pbx_password.TabStop = false;
            // 
            // pbx_user
            // 
            pbx_user.Anchor = AnchorStyles.Top;
            pbx_user.BackColor = Color.Transparent;
            pbx_user.Image = Properties.Resources.user;
            pbx_user.Location = new Point(89, 184);
            pbx_user.Name = "pbx_user";
            pbx_user.Size = new Size(25, 27);
            pbx_user.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_user.TabIndex = 18;
            pbx_user.TabStop = false;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.Top;
            btn_register.BackColor = Color.FromArgb(168, 28, 7);
            btn_register.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(120, 402);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(240, 46);
            btn_register.TabIndex = 16;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top;
            btn_login.BackColor = Color.FromArgb(168, 28, 7);
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(89, 488);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 39);
            btn_login.TabIndex = 17;
            btn_login.Text = "LOG IN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tbx_username
            // 
            tbx_username.Anchor = AnchorStyles.Top;
            tbx_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_username.Location = new Point(120, 184);
            tbx_username.Name = "tbx_username";
            tbx_username.PlaceholderText = " Username";
            tbx_username.Size = new Size(240, 27);
            tbx_username.TabIndex = 13;
            tbx_username.KeyDown += Registration_KeyDown;
            tbx_username.KeyPress += EnterKey;
            // 
            // lbl_userregistration
            // 
            lbl_userregistration.Anchor = AnchorStyles.Top;
            lbl_userregistration.AutoSize = true;
            lbl_userregistration.BackColor = Color.Transparent;
            lbl_userregistration.Font = new Font("Great Vibes", 37.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_userregistration.ForeColor = Color.White;
            lbl_userregistration.Location = new Point(12, 80);
            lbl_userregistration.Name = "lbl_userregistration";
            lbl_userregistration.Size = new Size(435, 79);
            lbl_userregistration.TabIndex = 12;
            lbl_userregistration.Text = "User Registration";
            // 
            // pbx_hidepass
            // 
            pbx_hidepass.AccessibleDescription = "";
            pbx_hidepass.Anchor = AnchorStyles.Top;
            pbx_hidepass.BackColor = Color.White;
            pbx_hidepass.Cursor = Cursors.Hand;
            pbx_hidepass.Image = Properties.Resources.show_password;
            pbx_hidepass.Location = new Point(335, 264);
            pbx_hidepass.Name = "pbx_hidepass";
            pbx_hidepass.Size = new Size(25, 22);
            pbx_hidepass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_hidepass.TabIndex = 21;
            pbx_hidepass.TabStop = false;
            pbx_hidepass.Tag = "";
            pbx_hidepass.Click += pbx_hidepass_Click;
            // 
            // tbx_password
            // 
            tbx_password.Anchor = AnchorStyles.Top;
            tbx_password.Location = new Point(120, 261);
            tbx_password.Name = "tbx_password";
            tbx_password.PasswordChar = '•';
            tbx_password.PlaceholderText = " Password";
            tbx_password.Size = new Size(240, 27);
            tbx_password.TabIndex = 14;
            tbx_password.KeyDown += Registration_KeyDown;
            tbx_password.KeyPress += EnterKey;
            tbx_password.Leave += tbx_password_Leave;
            // 
            // pbx_showconfirmpass
            // 
            pbx_showconfirmpass.AccessibleDescription = "";
            pbx_showconfirmpass.Anchor = AnchorStyles.Top;
            pbx_showconfirmpass.BackColor = Color.White;
            pbx_showconfirmpass.Cursor = Cursors.Hand;
            pbx_showconfirmpass.Image = Properties.Resources.hide_password;
            pbx_showconfirmpass.Location = new Point(335, 343);
            pbx_showconfirmpass.Name = "pbx_showconfirmpass";
            pbx_showconfirmpass.Size = new Size(25, 22);
            pbx_showconfirmpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_showconfirmpass.TabIndex = 24;
            pbx_showconfirmpass.TabStop = false;
            pbx_showconfirmpass.Click += pbx_showconfirmpass_Click;
            // 
            // pbx_confirmpass
            // 
            pbx_confirmpass.Anchor = AnchorStyles.Top;
            pbx_confirmpass.BackColor = Color.Transparent;
            pbx_confirmpass.Image = Properties.Resources.lock_png_icon_0;
            pbx_confirmpass.Location = new Point(89, 340);
            pbx_confirmpass.Name = "pbx_confirmpass";
            pbx_confirmpass.Size = new Size(25, 27);
            pbx_confirmpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_confirmpass.TabIndex = 23;
            pbx_confirmpass.TabStop = false;
            // 
            // pbx_hideconfirmpass
            // 
            pbx_hideconfirmpass.AccessibleDescription = "";
            pbx_hideconfirmpass.Anchor = AnchorStyles.Top;
            pbx_hideconfirmpass.BackColor = Color.White;
            pbx_hideconfirmpass.Cursor = Cursors.Hand;
            pbx_hideconfirmpass.Image = Properties.Resources.show_password;
            pbx_hideconfirmpass.Location = new Point(335, 343);
            pbx_hideconfirmpass.Name = "pbx_hideconfirmpass";
            pbx_hideconfirmpass.Size = new Size(25, 22);
            pbx_hideconfirmpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_hideconfirmpass.TabIndex = 25;
            pbx_hideconfirmpass.TabStop = false;
            pbx_hideconfirmpass.Tag = "";
            pbx_hideconfirmpass.Click += pbx_hideconfirmpass_Click;
            // 
            // tbx_confirmpassword
            // 
            tbx_confirmpassword.Anchor = AnchorStyles.Top;
            tbx_confirmpassword.Location = new Point(120, 340);
            tbx_confirmpassword.Name = "tbx_confirmpassword";
            tbx_confirmpassword.PasswordChar = '•';
            tbx_confirmpassword.PlaceholderText = " Confirm Password";
            tbx_confirmpassword.Size = new Size(240, 27);
            tbx_confirmpassword.TabIndex = 15;
            tbx_confirmpassword.KeyDown += Registration_KeyDown;
            tbx_confirmpassword.KeyPress += EnterKey;
            tbx_confirmpassword.Leave += tbx_confirmpassword_Leave;
            // 
            // lbl_haveaccount
            // 
            lbl_haveaccount.Anchor = AnchorStyles.Top;
            lbl_haveaccount.AutoSize = true;
            lbl_haveaccount.BackColor = Color.Transparent;
            lbl_haveaccount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_haveaccount.ForeColor = Color.Transparent;
            lbl_haveaccount.Location = new Point(80, 465);
            lbl_haveaccount.Name = "lbl_haveaccount";
            lbl_haveaccount.Size = new Size(123, 20);
            lbl_haveaccount.TabIndex = 26;
            lbl_haveaccount.Text = "Have an account?";
            // 
            // lbl_passwordweak
            // 
            lbl_passwordweak.AutoSize = true;
            lbl_passwordweak.BackColor = Color.Transparent;
            lbl_passwordweak.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_passwordweak.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_passwordweak.Location = new Point(120, 238);
            lbl_passwordweak.Name = "lbl_passwordweak";
            lbl_passwordweak.Size = new Size(280, 20);
            lbl_passwordweak.TabIndex = 27;
            lbl_passwordweak.Text = "Password must be more than 5 characters.";
            lbl_passwordweak.Visible = false;
            // 
            // lbl_passwordnotequal
            // 
            lbl_passwordnotequal.AutoSize = true;
            lbl_passwordnotequal.BackColor = Color.Transparent;
            lbl_passwordnotequal.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_passwordnotequal.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_passwordnotequal.Location = new Point(120, 317);
            lbl_passwordnotequal.Name = "lbl_passwordnotequal";
            lbl_passwordnotequal.Size = new Size(163, 20);
            lbl_passwordnotequal.TabIndex = 28;
            lbl_passwordnotequal.Text = "Password do not match.";
            lbl_passwordnotequal.Visible = false;
            // 
            // lbl_capslockon
            // 
            lbl_capslockon.AutoSize = true;
            lbl_capslockon.BackColor = Color.Transparent;
            lbl_capslockon.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_capslockon.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_capslockon.Location = new Point(120, 218);
            lbl_capslockon.Name = "lbl_capslockon";
            lbl_capslockon.Size = new Size(111, 20);
            lbl_capslockon.TabIndex = 29;
            lbl_capslockon.Text = "Caps Lock is on.";
            lbl_capslockon.Visible = false;
            // 
            // lbl_capslockon1
            // 
            lbl_capslockon1.AutoSize = true;
            lbl_capslockon1.BackColor = Color.Transparent;
            lbl_capslockon1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_capslockon1.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_capslockon1.Location = new Point(120, 297);
            lbl_capslockon1.Name = "lbl_capslockon1";
            lbl_capslockon1.Size = new Size(111, 20);
            lbl_capslockon1.TabIndex = 30;
            lbl_capslockon1.Text = "Caps Lock is on.";
            lbl_capslockon1.Visible = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 579);
            Controls.Add(lbl_capslockon1);
            Controls.Add(lbl_capslockon);
            Controls.Add(lbl_passwordnotequal);
            Controls.Add(lbl_passwordweak);
            Controls.Add(lbl_haveaccount);
            Controls.Add(pbx_showconfirmpass);
            Controls.Add(pbx_confirmpass);
            Controls.Add(pbx_hideconfirmpass);
            Controls.Add(tbx_confirmpassword);
            Controls.Add(pbx_showpass);
            Controls.Add(pbx_password);
            Controls.Add(pbx_user);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(tbx_username);
            Controls.Add(lbl_userregistration);
            Controls.Add(pbx_hidepass);
            Controls.Add(tbx_password);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            FormClosing += Registration_FormClosing;
            KeyDown += Registration_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbx_showpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hidepass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_showconfirmpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_confirmpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hideconfirmpass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbx_showpass;
        private PictureBox pbx_password;
        private PictureBox pbx_user;
        private Button btn_register;
        private Button btn_login;
        private TextBox tbx_username;
        private Label lbl_userregistration;
        private PictureBox pbx_hidepass;
        private TextBox tbx_password;
        private PictureBox pbx_showconfirmpass;
        private PictureBox pbx_confirmpass;
        private PictureBox pbx_hideconfirmpass;
        private TextBox tbx_confirmpassword;
        private Label lbl_haveaccount;
        private Label lbl_passwordweak;
        private Label lbl_passwordnotequal;
        private Label lbl_capslockon;
        private Label lbl_capslockon1;
    }
}