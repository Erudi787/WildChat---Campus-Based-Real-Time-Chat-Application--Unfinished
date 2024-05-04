using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildChat
{
    public partial class ReceivedMessage : UserControl
    {
        public ReceivedMessage()
        {
            InitializeComponent();
            Circular_PictureBox();
        }

        private Image _icon;
        private string _msg;
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pbx_userpic.Image = value; AddHeightText(); }
        }
        public string Message
        {
            get { return _msg; }
            set { _msg = value; lbl_receivedmessage.Text = _msg; }
        }

        void AddHeightText()
        {
            ReceivedMessage user = new ReceivedMessage();
            user.BringToFront();
            lbl_receivedmessage.Height = UiList.GetTextHeight(lbl_receivedmessage) + 10;
            user.Height = lbl_receivedmessage.Top + lbl_receivedmessage.Height;
            this.Height = user.Bottom + 10;
        }

        private void ReceivedMessage_Load(object sender, EventArgs e)
        {
            AddHeightText();
        }
        private void Circular_PictureBox()
        {
            pbx_userpic.Paint += pbx_Paint;
            pbx_userpic.Refresh();
        }
        private void pbx_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pbx_userpic.Width, pbx_userpic.Height);
            pbx_userpic.Region = new Region(path);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}
