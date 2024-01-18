using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_V3
{
    internal class MyCircle : Shape
    {
        private float _radius;
        public MyCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color bgColor, bool isPattern)
            : base(sPoint, ePoint, borderWidth, borderColor, bgColor, isPattern)
        {
            _radius = sPoint.X;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(_borderColor, _borderWidth);

            SizeF size = new SizeF(_radius, _radius);
            RectangleF cirle = new RectangleF(_location, size);

            if (_isPattern == true)
            {
                HatchBrush hatchBrush = new HatchBrush(HatchStyle.Cross, _borderColor, Color.White);
                g.FillEllipse(hatchBrush, cirle);
            }
            else
            {
                SolidBrush brush = new SolidBrush(_bgColor);
                g.FillEllipse(brush, cirle);
            }

            
            g.DrawEllipse(pen, cirle);
        }
    }
}
