using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace InsideHouse
{
    internal class DiamondPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grpath = new GraphicsPath();

            Point[] diamondPoints = {
                new Point(ClientSize.Width / 2, 0), 
                new Point(ClientSize.Width, ClientSize.Height / 2), 
                new Point(ClientSize.Width / 2, ClientSize.Height), 
                new Point(0, ClientSize.Height / 2) 
            };

            grpath.AddPolygon(diamondPoints);
            this.Region = new Region(grpath);
            base.OnPaint(pe);
        }
    }
}
