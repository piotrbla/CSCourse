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
        private List<List<CSAlgoLibrary.Point>> _layout = CSAlgoLibrary.TreeLayout.GetLayout(0, 0, 0);
        private readonly Pen _colorPen = new(Color.Blue);
        private int _rowCount = 1;
        public frmAlgo()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            _layout = CSAlgoLibrary.TreeLayout.GetLayout(
                _rowCount, drawingBox.Width, drawingBox.Height);
            _rowCount++;
            drawingBox.Invalidate();
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (List<CSAlgoLibrary.Point> points in _layout)
            {
                foreach (CSAlgoLibrary.Point point in points)
                {
                    e.Graphics.DrawEllipse(_colorPen, point.X, point.Y, 10, 10);
                }
            }
        }
    }
}
