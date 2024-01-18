using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_V3
{
    internal abstract class Shape
    {
        protected Point _location;
        protected int _borderWidth;
        protected Color _borderColor;
        protected Color _bgColor;
        protected bool _isPattern;

        public Shape(Point sPoint, Point ePoint, int boderWidth, Color borderColor, 
            Color bgColor, bool isPattern)
        {
            _location = sPoint;
            _borderWidth = boderWidth;
            _borderColor = borderColor;
            _bgColor = bgColor;
            _isPattern = isPattern;
        }

        public abstract void Draw(Graphics g);
    }
}
