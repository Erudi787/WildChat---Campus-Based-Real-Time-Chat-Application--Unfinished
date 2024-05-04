using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildChat
{
    internal class UiList
    {
        public static int GetTextHeight(Label label)
        {
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, label.Width);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
