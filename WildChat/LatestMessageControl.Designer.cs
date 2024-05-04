using System.Windows.Forms;
using System.Xml.Linq;

namespace WildChat
{
    partial class LatestMessageControl
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
            lbl_latestmessage = new Label();
            pbx_userimage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx_userimage).BeginInit();
            SuspendLayout();
            // 
            // lbl_latestmessage
            // 
            lbl_latestmessage.AutoSize = true;
            lbl_latestmessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_latestmessage.ForeColor = Color.White;
            lbl_latestmessage.Location = new Point(61, 19);
            lbl_latestmessage.Name = "lbl_latestmessage";
            lbl_latestmessage.Size = new Size(119, 20);
            lbl_latestmessage.TabIndex = 5;
            lbl_latestmessage.Text = "{latest_message}";
            // 
            // pbx_userimage
            // 
            pbx_userimage.BackColor = SystemColors.ControlDark;
            pbx_userimage.Location = new Point(15, 8);
            pbx_userimage.Name = "pbx_userimage";
            pbx_userimage.Size = new Size(40, 40);
            pbx_userimage.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_userimage.TabIndex = 4;
            pbx_userimage.TabStop = false;
            // 
            // LatestMessageControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lbl_latestmessage);
            Controls.Add(pbx_userimage);
            Name = "LatestMessageControl";
            Size = new Size(298, 47);
            ((System.ComponentModel.ISupportInitialize)pbx_userimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_latestmessage;
        private PictureBox pbx_userimage;
    }
}
