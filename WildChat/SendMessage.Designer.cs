namespace WildChat
{
    partial class SendMessage
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
            lbl_sendmessage = new Label();
            SuspendLayout();
            // 
            // lbl_sendmessage
            // 
            lbl_sendmessage.BackColor = Color.Turquoise;
            lbl_sendmessage.Dock = DockStyle.Top;
            lbl_sendmessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_sendmessage.ForeColor = Color.White;
            lbl_sendmessage.Location = new Point(0, 0);
            lbl_sendmessage.Name = "lbl_sendmessage";
            lbl_sendmessage.Size = new Size(407, 37);
            lbl_sendmessage.TabIndex = 4;
            lbl_sendmessage.Text = "{message}";
            lbl_sendmessage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SendMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lbl_sendmessage);
            Name = "SendMessage";
            Size = new Size(407, 37);
            Load += SendMessage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_sendmessage;
    }
}
