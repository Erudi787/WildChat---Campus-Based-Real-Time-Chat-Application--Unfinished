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
    public partial class userlist : UserControl
    {
        public userlist()
        {
            InitializeComponent();
            Circular_PictureBox();
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; lbl_user.Text = _title; }
        }
        private Image _icon;
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pbx_userpic.Image = _icon; }
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
