using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WildChat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_userlogin = new Label();
            tbx_username = new TextBox();
            tbx_password = new TextBox();
            btn_login = new Button();
            btn_register = new Button();
            lnklbl_forgotpass = new LinkLabel();
            pbx_user = new PictureBox();
            pbx_password = new PictureBox();
            pbx_showpass = new PictureBox();
            pbx_hidepass = new PictureBox();
            tooltip = new ToolTip(components);
            lbl_capslockon = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_showpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hidepass).BeginInit();
            SuspendLayout();
            // 
            // lbl_userlogin
            // 
            lbl_userlogin.Anchor = AnchorStyles.Top;
            lbl_userlogin.AutoSize = true;
            lbl_userlogin.Font = new Font("Great Vibes", 37.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_userlogin.ForeColor = Color.White;
            lbl_userlogin.Location = new Point(60, 33);
            lbl_userlogin.Name = "lbl_userlogin";
            lbl_userlogin.Size = new Size(298, 79);
            lbl_userlogin.TabIndex = 0;
            lbl_userlogin.Text = "User Login";
            // 
            // tbx_username
            // 
            tbx_username.Anchor = AnchorStyles.Top;
            tbx_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_username.Location = new Point(100, 146);
            tbx_username.Name = "tbx_username";
            tbx_username.PlaceholderText = " Username";
            tbx_username.Size = new Size(240, 27);
            tbx_username.TabIndex = 1;
            tbx_username.KeyDown += Form1_KeyDown;
            tbx_username.KeyPress += EnterKey;
            // 
            // tbx_password
            // 
            tbx_password.Anchor = AnchorStyles.Top;
            tbx_password.Location = new Point(100, 199);
            tbx_password.Name = "tbx_password";
            tbx_password.PasswordChar = '•';
            tbx_password.PlaceholderText = " Password";
            tbx_password.Size = new Size(240, 27);
            tbx_password.TabIndex = 2;
            tbx_password.KeyDown += Form1_KeyDown;
            tbx_password.KeyPress += EnterKey;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top;
            btn_login.BackColor = Color.Transparent;
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(100, 262);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 39);
            btn_login.TabIndex = 5;
            btn_login.Text = "LOG IN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.MouseHover += btn_login_MouseHover;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.Top;
            btn_register.BackColor = Color.Transparent;
            btn_register.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(246, 262);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(94, 39);
            btn_register.TabIndex = 6;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            btn_register.MouseHover += btn_register_MouseHover;
            // 
            // lnklbl_forgotpass
            // 
            lnklbl_forgotpass.Anchor = AnchorStyles.Top;
            lnklbl_forgotpass.AutoSize = true;
            lnklbl_forgotpass.LinkColor = Color.Silver;
            lnklbl_forgotpass.Location = new Point(151, 229);
            lnklbl_forgotpass.Name = "lnklbl_forgotpass";
            lnklbl_forgotpass.Size = new Size(127, 20);
            lnklbl_forgotpass.TabIndex = 7;
            lnklbl_forgotpass.TabStop = true;
            lnklbl_forgotpass.Text = "Forgot password?";
            lnklbl_forgotpass.LinkClicked += lnklbl_forgotpass_LinkClicked;
            // 
            // pbx_user
            // 
            pbx_user.Anchor = AnchorStyles.Top;
            pbx_user.Image = Properties.Resources.user;
            pbx_user.Location = new Point(69, 146);
            pbx_user.Name = "pbx_user";
            pbx_user.Size = new Size(25, 27);
            pbx_user.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_user.TabIndex = 8;
            pbx_user.TabStop = false;
            // 
            // pbx_password
            // 
            pbx_password.Anchor = AnchorStyles.Top;
            pbx_password.Image = Properties.Resources.lock_png_icon_0;
            pbx_password.Location = new Point(69, 197);
            pbx_password.Name = "pbx_password";
            pbx_password.Size = new Size(25, 27);
            pbx_password.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_password.TabIndex = 9;
            pbx_password.TabStop = false;
            // 
            // pbx_showpass
            // 
            pbx_showpass.AccessibleDescription = "";
            pbx_showpass.Anchor = AnchorStyles.Top;
            pbx_showpass.Cursor = Cursors.Hand;
            pbx_showpass.Image = Properties.Resources.hide_password;
            pbx_showpass.Location = new Point(315, 202);
            pbx_showpass.Name = "pbx_showpass";
            pbx_showpass.Size = new Size(25, 22);
            pbx_showpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_showpass.TabIndex = 10;
            pbx_showpass.TabStop = false;
            pbx_showpass.Click += pbx_showpass_Click;
            pbx_showpass.MouseHover += pbx_showpass_MouseHover;
            // 
            // pbx_hidepass
            // 
            pbx_hidepass.AccessibleDescription = "";
            pbx_hidepass.Anchor = AnchorStyles.Top;
            pbx_hidepass.Cursor = Cursors.Hand;
            pbx_hidepass.Image = Properties.Resources.show_password;
            pbx_hidepass.Location = new Point(315, 202);
            pbx_hidepass.Name = "pbx_hidepass";
            pbx_hidepass.Size = new Size(25, 22);
            pbx_hidepass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_hidepass.TabIndex = 11;
            pbx_hidepass.TabStop = false;
            pbx_hidepass.Tag = "";
            pbx_hidepass.Click += pbx_hidepass_Click;
            pbx_hidepass.MouseHover += pbx_hidepass_MouseHover;
            // 
            // lbl_capslockon
            // 
            lbl_capslockon.AutoSize = true;
            lbl_capslockon.BackColor = Color.Transparent;
            lbl_capslockon.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_capslockon.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_capslockon.Location = new Point(100, 176);
            lbl_capslockon.Name = "lbl_capslockon";
            lbl_capslockon.Size = new Size(111, 20);
            lbl_capslockon.TabIndex = 30;
            lbl_capslockon.Text = "Caps Lock is on.";
            lbl_capslockon.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 357);
            Controls.Add(lbl_capslockon);
            Controls.Add(pbx_showpass);
            Controls.Add(pbx_password);
            Controls.Add(pbx_user);
            Controls.Add(lnklbl_forgotpass);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(tbx_username);
            Controls.Add(lbl_userlogin);
            Controls.Add(pbx_hidepass);
            Controls.Add(tbx_password);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WildChat";
            FormClosing += Form1_FormClosing;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbx_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_showpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hidepass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_userlogin;
        private TextBox tbx_username;
        private TextBox tbx_password;
        private Button btn_login;
        private Button btn_register;
        private LinkLabel lnklbl_forgotpass;
        private PictureBox pbx_user;
        private PictureBox pbx_password;
        private PictureBox pbx_showpass;
        private PictureBox pbx_hidepass;
        private ToolTip tooltip;
        private Label lbl_capslockon;
    }
}
