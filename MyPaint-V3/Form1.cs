using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint_V3
{
    public partial class Form1 : Form
    {
        private Graphics _graphic;
        private Point _aPoint;
        private Point _sPoint;
        private bool _moving;
        private bool _isPattern;
        private Color penColor;
        private Color penBackgroundColor;
        private LinkedList<Shape> _shape;

        public Form1()
        {
            InitializeComponent();

            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _shape = new LinkedList<Shape>();
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint = e.Location;
            _moving = true;
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Shape s = GetShape(e.Location);
            _shape.AddLast(s);

            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint))
            {
                return;
            }

            RefreshPanel();

            Shape s = GetShape(e.Location);
            s.Draw(_graphic);
            //_shape.AddLast(s);
        }

        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);

            foreach (Shape shape in _shape)
            {
                shape.Draw(_graphic);
            }
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            if(cdColor1.ShowDialog() == DialogResult.OK)
            {
                lb1Color.ForeColor = cdColor1.Color;
            }
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            if (cdColor2.ShowDialog() == DialogResult.OK)
            {
                lb2Color.ForeColor = cdColor2.Color;
            }
        }

        private Shape GetShape(Point ePoint)
        {
            int penWidth = (int)inpPenWidth.Value;
            penColor = cdColor1.Color;
            penBackgroundColor = Color.White;
            Shape s;


            if (rbdRectangle.Checked)
            {
                if (rdbNoFill.Checked)
                {
                    _isPattern = false;
                    s = new MyRectangle(_sPoint, ePoint, penWidth
                        , penColor, penBackgroundColor, _isPattern);

                }
                else if (rdbColorFill.Checked)
                {
                    _isPattern = false;
                    penBackgroundColor = cdColor2.Color;
                    s = new MyRectangle(_sPoint, ePoint, penWidth
                        , penColor, penBackgroundColor, _isPattern);

                }
                else
                {
                    _isPattern = true;
                    s = new MyRectangle(_sPoint, ePoint, penWidth
                        , penColor, penBackgroundColor, _isPattern);
                }
            }
            else
            {
                if (rdbNoFill.Checked)
                {
                    _isPattern = false;
                    s = new MyCircle(_sPoint, ePoint, penWidth
                        , penColor, penBackgroundColor, _isPattern);
                }
                else if (rdbColorFill.Checked)
                {
                    _isPattern = false;
                    penBackgroundColor = cdColor2.Color;
                    s = new MyCircle(_sPoint, ePoint, penWidth
                        , penColor, penBackgroundColor, _isPattern);
                }
                else
                {
                    _isPattern = true;
                    penBackgroundColor = cdColor2.Color;
                    s = new MyCircle(_sPoint, ePoint, penWidth
                        , penColor, penBackgroundColor, _isPattern);
                }
            }

            return s;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
