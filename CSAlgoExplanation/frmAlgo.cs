using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAlgoExplanation
{
    public partial class frmAlgo : Form
    {
        internal class StringDraw
        {
            private Graphics _g;
            private Font _font;
            private Brush _brush;
            public StringDraw(Graphics g)
            {
                _g = g;
                _font = new Font("Arial", 16);
                _brush = new SolidBrush(Color.Black);
            }
            public void Draw(string s, CSAlgoLibrary.Point p)
            {
                _g.DrawString(s, _font, _brush, p.X-10, p.Y-10);
            }
        }
        private List<List<CSAlgoLibrary.Point>> _layout = CSAlgoLibrary.TreeLayout.GetLayout(0, 0, 0);
        private readonly Pen _colorPen = new(Color.Blue);
        private int _rowCount = 1;
        public frmAlgo()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            _rowCount = 4;
            _layout = CSAlgoLibrary.TreeLayout.GetLayout(
                _rowCount, drawingBox.Width, drawingBox.Height);
            _rowCount++;
            drawingBox.Invalidate();
        }

        private void DrawShorterLine(Pen pen, CSAlgoLibrary.Point start, CSAlgoLibrary.Point end, int offset,PaintEventArgs e)
        {
            var diffX = end.X - start.X;
            var diffY = end.Y - start.Y;
            var slope = (double)diffY / diffX;
            var angle = Math.Atan(slope);
            var length = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            var newLength = length - offset;
            if (angle < 0)
            {
                newLength *= -1;
                offset *= -1; 
            }
            var newStartX = start.X + offset * Math.Cos(angle);
            var newStartY = start.Y + offset * Math.Sin(angle);
            var newEndX = start.X + newLength * Math.Cos(angle);
            var newEndY = start.Y + newLength * Math.Sin(angle);
            e.Graphics.DrawLine(pen, 
                (float)newStartX, (float)newStartY, 
                (float)newEndX, (float)newEndY);
        }
        public class MyCustomAttribute : Attribute
        {
        }

        [MyCustom]
        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {
            var circleRadius = 25;
            foreach (List<CSAlgoLibrary.Point> points in _layout)
            {
                foreach (CSAlgoLibrary.Point point in points)
                {
                    e.Graphics.DrawEllipse(_colorPen, 
                        point.X-circleRadius, point.Y- circleRadius,
                        circleRadius*2, circleRadius*2);
                }
            }
            if (_layout.Count>1)
            {

                var upperRow = _layout[0];
                var lowerRow = _layout[1];
                for (int row = 0; row < _layout.Count-1; row++)
                {
                    for (int i = 0, j = 0; i < upperRow.Count; i++, j += 2)
                    {
                        DrawShorterLine(_colorPen, upperRow[i], lowerRow[j], circleRadius, e);
                        DrawShorterLine(_colorPen, upperRow[i], lowerRow[j+1], circleRadius, e);
                        //e.Graphics.DrawLine(_colorPen, upperRow[i].X, upperRow[i].Y, lowerRow[j].X, lowerRow[j].Y);
                        //e.Graphics.DrawLine(_colorPen, upperRow[i].X, upperRow[i].Y, lowerRow[j + 1].X, lowerRow[j + 1].Y);
                    }
                    upperRow = lowerRow;
                    if(row+2 <= _layout.Count - 1)
                        lowerRow = _layout[row + 2];
                }
            }
            //presentation code for specific tree: 6, 2, 1, 4, 3, 5, 7, 9, 8
            if (_layout.Count == 4)
            {
                var draw = new StringDraw(e.Graphics);
                draw.Draw("6", _layout[0][0]);
                draw.Draw("2", _layout[1][0]);
                draw.Draw("1", _layout[2][0]);
                draw.Draw("4", _layout[2][1]);
                draw.Draw("3", _layout[3][2]);
                draw.Draw("5", _layout[3][3]);
                draw.Draw("7", _layout[1][1]);
                draw.Draw("9", _layout[2][3]);
                draw.Draw("8", _layout[3][6]);
            }
        }
    }
}
