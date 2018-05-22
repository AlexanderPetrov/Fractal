using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class MainForm : Form
    {
        Graphics _g;
        float _pointSize = 2.0f;
        bool _started = false;
        Dictionary<int, PointF> _points;
        int _pointCount = 0;
        private int _iteration;
        PointF _tracePoint;
        Task _drawTask;

        static Random r = new Random();

        public MainForm()
        {
            InitializeComponent();
            _points = new Dictionary<int, PointF>();
            _iteration = 0;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (_started)
                return;

            if (_g == null)
                _g = this.CreateGraphics();

            _points.Add(_pointCount++, new PointF(e.X, e.Y));

            _g.FillEllipse(Brushes.Black, new RectangleF(
                (float)e.X - (_pointSize / 2.0f),
                (float)e.Y - (_pointSize / 2.0f),
                _pointSize, _pointSize));
        }

        private void btClearPoints_Click(object sender, EventArgs e)
        {
            if (_g != null)
            {
                _g.Clear(Color.LightGray);
                ClearPoints();
            }
        }

        private void ClearPoints()
        {
            _points.Clear();
            _pointCount = 0;
            _iteration = 0;
        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            _started = !_started;

            if(_started)
            {
                _tracePoint = _points[_pointCount - 1];
                _drawTask = Task.Factory.StartNew(DrawFractal);
            }
            else
            {
                _drawTask = null;
            }
        }

        private async void DrawFractal()
        {
            while (_started)
            {
                //Thread.Sleep(100);

                int key = r.Next(0, _pointCount);
                PointF toPoint = _points[key];

                float x = _tracePoint.X - ((_tracePoint.X - toPoint.X) / 2.0f);
                float y = _tracePoint.Y - ((_tracePoint.Y - toPoint.Y) / 2.0f);

                _g.FillEllipse(Brushes.Black, new RectangleF(
                x - (_pointSize / 2.0f),
                y - (_pointSize / 2.0f),
                _pointSize, _pointSize));

                _tracePoint = new PointF(x, y);
            }
        }

        private void btDrawNew_Click(object sender, EventArgs e)
        {
            ClearPoints();
        }
    }
}
