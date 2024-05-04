namespace WildChat
{
    partial class ReceivedMessage
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
            lbl_receivedmessage = new Label();
            pbx_userpic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx_userpic).BeginInit();
            SuspendLayout();
            // 
            // lbl_receivedmessage
            // 
            lbl_receivedmessage.BackColor = Color.MediumSeaGreen;
            lbl_receivedmessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_receivedmessage.ForeColor = Color.White;
            lbl_receivedmessage.Location = new Point(67, 0);
            lbl_receivedmessage.Name = "lbl_receivedmessage";
            lbl_receivedmessage.Size = new Size(342, 60);
            lbl_receivedmessage.TabIndex = 3;
            lbl_receivedmessage.Text = "{message}";
            // 
            // pbx_userpic
            // 
            pbx_userpic.BackColor = SystemColors.ControlDark;
            pbx_userpic.Location = new Point(21, 0);
            pbx_userpic.Name = "pbx_userpic";
            pbx_userpic.Size = new Size(40, 40);
            pbx_userpic.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_userpic.TabIndex = 2;
            pbx_userpic.TabStop = false;
            // 
            // ReceivedMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pbx_userpic);
            Controls.Add(lbl_receivedmessage);
            Name = "ReceivedMessage";
            Size = new Size(409, 71);
            Load += ReceivedMessage_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_userpic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_receivedmessage;
        private PictureBox pbx_userpic;
    }
}
