using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WildChat
{
    partial class PasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChange));
            pbx_user = new PictureBox();
            tbx_username = new TextBox();
            lbl_userregistration = new Label();
            lbl_enterusername = new Label();
            btn_continue = new Button();
            btn_back = new Button();
            pnl_continue = new Panel();
            btn_changepass = new Button();
            btn_back1 = new Button();
            tbx_password = new TextBox();
            pbx_hidepass = new PictureBox();
            pbx_password = new PictureBox();
            pbx_showpass = new PictureBox();
            tbx_confirmpassword = new TextBox();
            pbx_hideconfirmpass = new PictureBox();
            pbx_confirmpass = new PictureBox();
            pbx_showconfirmpass = new PictureBox();
            lbl_passwordweak = new Label();
            lbl_passwordnotequal = new Label();
            pnl_changepass = new Panel();
            lbl_capslockon1 = new Label();
            lbl_capslockon = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_user).BeginInit();
            pnl_continue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_hidepass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_showpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hideconfirmpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_confirmpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_showconfirmpass).BeginInit();
            pnl_changepass.SuspendLayout();
            SuspendLayout();
            // 
            // pbx_user
            // 
            pbx_user.Anchor = AnchorStyles.Top;
            pbx_user.BackColor = Color.Transparent;
            pbx_user.Image = Properties.Resources.user;
            pbx_user.Location = new Point(91, 206);
            pbx_user.Name = "pbx_user";
            pbx_user.Size = new Size(25, 27);
            pbx_user.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_user.TabIndex = 22;
            pbx_user.TabStop = false;
            // 
            // tbx_username
            // 
            tbx_username.Anchor = AnchorStyles.Top;
            tbx_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_username.Location = new Point(122, 206);
            tbx_username.Name = "tbx_username";
            tbx_username.PlaceholderText = " Username";
            tbx_username.Size = new Size(240, 27);
            tbx_username.TabIndex = 20;
            tbx_username.KeyPress += EnterKey;
            // 
            // lbl_userregistration
            // 
            lbl_userregistration.Anchor = AnchorStyles.Top;
            lbl_userregistration.AutoSize = true;
            lbl_userregistration.BackColor = Color.Transparent;
            lbl_userregistration.Font = new Font("Great Vibes", 37.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_userregistration.ForeColor = Color.White;
            lbl_userregistration.Location = new Point(14, 84);
            lbl_userregistration.Name = "lbl_userregistration";
            lbl_userregistration.Size = new Size(427, 79);
            lbl_userregistration.TabIndex = 19;
            lbl_userregistration.Text = "Change Password";
            // 
            // lbl_enterusername
            // 
            lbl_enterusername.Anchor = AnchorStyles.Top;
            lbl_enterusername.AutoSize = true;
            lbl_enterusername.BackColor = Color.Transparent;
            lbl_enterusername.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_enterusername.ForeColor = Color.White;
            lbl_enterusername.Location = new Point(78, 183);
            lbl_enterusername.Name = "lbl_enterusername";
            lbl_enterusername.Size = new Size(107, 17);
            lbl_enterusername.TabIndex = 23;
            lbl_enterusername.Text = "Enter username";
            // 
            // btn_continue
            // 
            btn_continue.Anchor = AnchorStyles.Top;
            btn_continue.BackColor = Color.FromArgb(168, 28, 7);
            btn_continue.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_continue.FlatStyle = FlatStyle.Flat;
            btn_continue.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_continue.ForeColor = Color.White;
            btn_continue.Location = new Point(122, 14);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(240, 46);
            btn_continue.TabIndex = 25;
            btn_continue.Text = "CONTINUE";
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += btn_continue_Click;
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Top;
            btn_back.BackColor = Color.FromArgb(168, 28, 7);
            btn_back.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(15, 109);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(137, 46);
            btn_back.TabIndex = 26;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // pnl_continue
            // 
            pnl_continue.Anchor = AnchorStyles.Top;
            pnl_continue.BackColor = Color.Transparent;
            pnl_continue.Controls.Add(btn_back);
            pnl_continue.Controls.Add(btn_continue);
            pnl_continue.Location = new Point(-1, 240);
            pnl_continue.Name = "pnl_continue";
            pnl_continue.Size = new Size(465, 336);
            pnl_continue.TabIndex = 24;
            // 
            // btn_changepass
            // 
            btn_changepass.Anchor = AnchorStyles.Top;
            btn_changepass.BackColor = Color.FromArgb(168, 28, 7);
            btn_changepass.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_changepass.FlatStyle = FlatStyle.Flat;
            btn_changepass.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_changepass.ForeColor = Color.White;
            btn_changepass.Location = new Point(123, 183);
            btn_changepass.Name = "btn_changepass";
            btn_changepass.Size = new Size(240, 46);
            btn_changepass.TabIndex = 39;
            btn_changepass.Text = "CHANGE PASSWORD";
            btn_changepass.UseVisualStyleBackColor = false;
            btn_changepass.Click += btn_changepass_Click;
            // 
            // btn_back1
            // 
            btn_back1.Anchor = AnchorStyles.Top;
            btn_back1.BackColor = Color.FromArgb(168, 28, 7);
            btn_back1.FlatAppearance.BorderColor = Color.FromArgb(168, 28, 7);
            btn_back1.FlatStyle = FlatStyle.Flat;
            btn_back1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back1.ForeColor = Color.White;
            btn_back1.Location = new Point(15, 256);
            btn_back1.Name = "btn_back1";
            btn_back1.Size = new Size(137, 46);
            btn_back1.TabIndex = 40;
            btn_back1.Text = "BACK";
            btn_back1.UseVisualStyleBackColor = false;
            btn_back1.Click += btn_back1_Click;
            // 
            // tbx_password
            // 
            tbx_password.Anchor = AnchorStyles.Top;
            tbx_password.Location = new Point(123, 52);
            tbx_password.Name = "tbx_password";
            tbx_password.PasswordChar = '•';
            tbx_password.PlaceholderText = " Password";
            tbx_password.Size = new Size(240, 27);
            tbx_password.TabIndex = 41;
            tbx_password.KeyDown += PasswordChange_KeyDown;
            tbx_password.KeyPress += EnterKey1;
            tbx_password.Leave += tbx_password_Leave;
            // 
            // pbx_hidepass
            // 
            pbx_hidepass.AccessibleDescription = "";
            pbx_hidepass.Anchor = AnchorStyles.Top;
            pbx_hidepass.BackColor = Color.White;
            pbx_hidepass.Cursor = Cursors.Hand;
            pbx_hidepass.Image = Properties.Resources.show_password;
            pbx_hidepass.Location = new Point(338, 55);
            pbx_hidepass.Name = "pbx_hidepass";
            pbx_hidepass.Size = new Size(25, 22);
            pbx_hidepass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_hidepass.TabIndex = 45;
            pbx_hidepass.TabStop = false;
            pbx_hidepass.Tag = "";
            pbx_hidepass.Click += pbx_hidepass_Click;
            // 
            // pbx_password
            // 
            pbx_password.Anchor = AnchorStyles.Top;
            pbx_password.BackColor = Color.Transparent;
            pbx_password.Image = Properties.Resources.lock_png_icon_0;
            pbx_password.Location = new Point(92, 52);
            pbx_password.Name = "pbx_password";
            pbx_password.Size = new Size(25, 27);
            pbx_password.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_password.TabIndex = 43;
            pbx_password.TabStop = false;
            // 
            // pbx_showpass
            // 
            pbx_showpass.AccessibleDescription = "";
            pbx_showpass.Anchor = AnchorStyles.Top;
            pbx_showpass.BackColor = Color.White;
            pbx_showpass.Cursor = Cursors.Hand;
            pbx_showpass.Image = Properties.Resources.hide_password;
            pbx_showpass.Location = new Point(338, 55);
            pbx_showpass.Name = "pbx_showpass";
            pbx_showpass.Size = new Size(25, 22);
            pbx_showpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_showpass.TabIndex = 44;
            pbx_showpass.TabStop = false;
            pbx_showpass.Click += pbx_showpass_Click;
            // 
            // tbx_confirmpassword
            // 
            tbx_confirmpassword.Anchor = AnchorStyles.Top;
            tbx_confirmpassword.Location = new Point(123, 135);
            tbx_confirmpassword.Name = "tbx_confirmpassword";
            tbx_confirmpassword.PasswordChar = '•';
            tbx_confirmpassword.PlaceholderText = " Confirm Password";
            tbx_confirmpassword.Size = new Size(240, 27);
            tbx_confirmpassword.TabIndex = 42;
            tbx_confirmpassword.KeyDown += PasswordChange_KeyDown;
            tbx_confirmpassword.KeyPress += EnterKey1;
            tbx_confirmpassword.Leave += tbx_confirmpassword_Leave;
            // 
            // pbx_hideconfirmpass
            // 
            pbx_hideconfirmpass.AccessibleDescription = "";
            pbx_hideconfirmpass.Anchor = AnchorStyles.Top;
            pbx_hideconfirmpass.BackColor = Color.White;
            pbx_hideconfirmpass.Cursor = Cursors.Hand;
            pbx_hideconfirmpass.Image = Properties.Resources.show_password;
            pbx_hideconfirmpass.Location = new Point(338, 138);
            pbx_hideconfirmpass.Name = "pbx_hideconfirmpass";
            pbx_hideconfirmpass.Size = new Size(25, 22);
            pbx_hideconfirmpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_hideconfirmpass.TabIndex = 48;
            pbx_hideconfirmpass.TabStop = false;
            pbx_hideconfirmpass.Tag = "";
            pbx_hideconfirmpass.Click += pbx_hideconfirmpass_Click;
            // 
            // pbx_confirmpass
            // 
            pbx_confirmpass.Anchor = AnchorStyles.Top;
            pbx_confirmpass.BackColor = Color.Transparent;
            pbx_confirmpass.Image = Properties.Resources.lock_png_icon_0;
            pbx_confirmpass.Location = new Point(92, 135);
            pbx_confirmpass.Name = "pbx_confirmpass";
            pbx_confirmpass.Size = new Size(25, 27);
            pbx_confirmpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_confirmpass.TabIndex = 46;
            pbx_confirmpass.TabStop = false;
            // 
            // pbx_showconfirmpass
            // 
            pbx_showconfirmpass.AccessibleDescription = "";
            pbx_showconfirmpass.Anchor = AnchorStyles.Top;
            pbx_showconfirmpass.BackColor = Color.White;
            pbx_showconfirmpass.Cursor = Cursors.Hand;
            pbx_showconfirmpass.Image = Properties.Resources.hide_password;
            pbx_showconfirmpass.Location = new Point(338, 138);
            pbx_showconfirmpass.Name = "pbx_showconfirmpass";
            pbx_showconfirmpass.Size = new Size(25, 22);
            pbx_showconfirmpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_showconfirmpass.TabIndex = 47;
            pbx_showconfirmpass.TabStop = false;
            pbx_showconfirmpass.Click += pbx_showconfirmpass_Click;
            // 
            // lbl_passwordweak
            // 
            lbl_passwordweak.AutoSize = true;
            lbl_passwordweak.BackColor = Color.Transparent;
            lbl_passwordweak.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_passwordweak.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_passwordweak.Location = new Point(123, 29);
            lbl_passwordweak.Name = "lbl_passwordweak";
            lbl_passwordweak.Size = new Size(280, 20);
            lbl_passwordweak.TabIndex = 49;
            lbl_passwordweak.Text = "Password must be more than 5 characters.";
            lbl_passwordweak.Visible = false;
            // 
            // lbl_passwordnotequal
            // 
            lbl_passwordnotequal.AutoSize = true;
            lbl_passwordnotequal.BackColor = Color.Transparent;
            lbl_passwordnotequal.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_passwordnotequal.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_passwordnotequal.Location = new Point(123, 112);
            lbl_passwordnotequal.Name = "lbl_passwordnotequal";
            lbl_passwordnotequal.Size = new Size(163, 20);
            lbl_passwordnotequal.TabIndex = 50;
            lbl_passwordnotequal.Text = "Password do not match.";
            lbl_passwordnotequal.Visible = false;
            // 
            // pnl_changepass
            // 
            pnl_changepass.Anchor = AnchorStyles.Top;
            pnl_changepass.BackColor = Color.Transparent;
            pnl_changepass.Controls.Add(lbl_capslockon1);
            pnl_changepass.Controls.Add(lbl_capslockon);
            pnl_changepass.Controls.Add(lbl_passwordnotequal);
            pnl_changepass.Controls.Add(lbl_passwordweak);
            pnl_changepass.Controls.Add(pbx_showconfirmpass);
            pnl_changepass.Controls.Add(pbx_confirmpass);
            pnl_changepass.Controls.Add(pbx_hideconfirmpass);
            pnl_changepass.Controls.Add(tbx_confirmpassword);
            pnl_changepass.Controls.Add(pbx_showpass);
            pnl_changepass.Controls.Add(pbx_password);
            pnl_changepass.Controls.Add(pbx_hidepass);
            pnl_changepass.Controls.Add(tbx_password);
            pnl_changepass.Controls.Add(btn_back1);
            pnl_changepass.Controls.Add(btn_changepass);
            pnl_changepass.Location = new Point(-1, 240);
            pnl_changepass.Name = "pnl_changepass";
            pnl_changepass.Size = new Size(465, 336);
            pnl_changepass.TabIndex = 27;
            // 
            // lbl_capslockon1
            // 
            lbl_capslockon1.AutoSize = true;
            lbl_capslockon1.BackColor = Color.Transparent;
            lbl_capslockon1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_capslockon1.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_capslockon1.Location = new Point(123, 92);
            lbl_capslockon1.Name = "lbl_capslockon1";
            lbl_capslockon1.Size = new Size(111, 20);
            lbl_capslockon1.TabIndex = 52;
            lbl_capslockon1.Text = "Caps Lock is on.";
            lbl_capslockon1.Visible = false;
            // 
            // lbl_capslockon
            // 
            lbl_capslockon.AutoSize = true;
            lbl_capslockon.BackColor = Color.Transparent;
            lbl_capslockon.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_capslockon.ForeColor = Color.FromArgb(255, 192, 192);
            lbl_capslockon.Location = new Point(123, 9);
            lbl_capslockon.Name = "lbl_capslockon";
            lbl_capslockon.Size = new Size(111, 20);
            lbl_capslockon.TabIndex = 51;
            lbl_capslockon.Text = "Caps Lock is on.";
            lbl_capslockon.Visible = false;
            // 
            // PasswordChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 587);
            Controls.Add(lbl_enterusername);
            Controls.Add(pbx_user);
            Controls.Add(tbx_username);
            Controls.Add(lbl_userregistration);
            Controls.Add(pnl_continue);
            Controls.Add(pnl_changepass);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(480, 634);
            Name = "PasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            FormClosing += PasswordChange_FormClosing;
            KeyDown += PasswordChange_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbx_user).EndInit();
            pnl_continue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_hidepass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_showpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hideconfirmpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_confirmpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_showconfirmpass).EndInit();
            pnl_changepass.ResumeLayout(false);
            pnl_changepass.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbx_user;
        private TextBox tbx_username;
        private Label lbl_userregistration;
        private Label lbl_enterusername;
        private Button btn_continue;
        private Button btn_back;
        private Panel pnl_continue;
        private Button btn_changepass;
        private Button btn_back1;
        private TextBox tbx_password;
        private PictureBox pbx_hidepass;
        private PictureBox pbx_password;
        private PictureBox pbx_showpass;
        private TextBox tbx_confirmpassword;
        private PictureBox pbx_hideconfirmpass;
        private PictureBox pbx_confirmpass;
        private PictureBox pbx_showconfirmpass;
        private Label lbl_passwordweak;
        private Label lbl_passwordnotequal;
        private Panel pnl_changepass;
        private Label lbl_capslockon1;
        private Label lbl_capslockon;
    }
}