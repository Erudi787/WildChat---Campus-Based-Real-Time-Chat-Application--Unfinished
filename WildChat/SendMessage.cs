using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildChat
{
    public partial class SendMessage : UserControl
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private string _msg;
        public string Message
        {
            get { return _msg; }
            set { _msg = value; lbl_sendmessage.Text = _msg; }
        }

        void AddHeightText()
        {
            SendMessage user = new SendMessage();
            user.BringToFront();
            lbl_sendmessage.Height = UiList.GetTextHeight(lbl_sendmessage) + 10;
            user.Height = lbl_sendmessage.Top + lbl_sendmessage.Height;
            this.Height = user.Bottom + 10;
        }

        private void SendMessage_Load(object sender, EventArgs e)
        {
            AddHeightText();
        }
    }
}
