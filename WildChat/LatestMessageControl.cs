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
    public partial class LatestMessageControl : UserControl
    {
        public LatestMessageControl()
        {
            InitializeComponent();
            Circular_PictureBox();
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; lbl_latestmessage.Text = _message; }
        }
        private Image _icon;
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pbx_userimage.Image = _icon; Circular_PictureBox(); }
        }
        private void Circular_PictureBox()
        {
            pbx_userimage.Paint += pbx_Paint;
            pbx_userimage.Refresh();
        }
        private void pbx_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pbx_userimage.Width, pbx_userimage.Height);
            pbx_userimage.Region = new Region(path);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}
