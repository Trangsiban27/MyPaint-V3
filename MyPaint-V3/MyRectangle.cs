using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_V3
{
    internal class MyRectangle : Shape
    {
        private int _width;
        private int _height;

        public MyRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color bgColor, bool isPattern) 
            : base(sPoint, ePoint, borderWidth, borderColor, bgColor, isPattern)
        {
            _width = ePoint.X - sPoint.X;
            _height = ePoint.Y - sPoint.Y;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(_borderColor, _borderWidth);

            Size size = new Size(_width, _height);
            Rectangle rect = new Rectangle(_location, size);


            if(_isPattern == true)
            {
                HatchBrush hatchBrush = new HatchBrush(HatchStyle.Cross, _borderColor, Color.White);
                g.FillRectangle(hatchBrush, rect);
            }
            else
            {
                SolidBrush brush = new SolidBrush(_bgColor);
                g.FillRectangle(brush, rect);
            }

            g.DrawRectangle(pen, rect);
        }
    }
}
