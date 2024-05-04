using System.Windows.Forms;
using System.Xml.Linq;

namespace WildChat
{
    partial class userlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_user = new Label();
            pbx_userpic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx_userpic).BeginInit();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_user.ForeColor = Color.White;
            lbl_user.Location = new Point(61, 19);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(48, 20);
            lbl_user.TabIndex = 3;
            lbl_user.Text = "{user}";
            // 
            // pbx_userpic
            // 
            pbx_userpic.BackColor = SystemColors.ControlDark;
            pbx_userpic.Location = new Point(15, 8);
            pbx_userpic.Name = "pbx_userpic";
            pbx_userpic.Size = new Size(40, 40);
            pbx_userpic.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_userpic.TabIndex = 2;
            pbx_userpic.TabStop = false;
            // 
            // userlist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lbl_user);
            Controls.Add(pbx_userpic);
            Name = "userlist";
            Size = new Size(298, 47);
            ((System.ComponentModel.ISupportInitialize)pbx_userpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user;
        private PictureBox pbx_userpic;
    }
}
