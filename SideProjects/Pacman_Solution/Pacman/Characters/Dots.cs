using System.Drawing;
using System.Windows.Forms;

namespace Pacman.Characters
{
    public class Dots : Control, IDots
    {
        public Dots()
        {
            Width = Height = 30;
        }

        public Dots(int point)
            : this()
        {
            _points = point;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen p = new Pen(Dot_Color);
            e.Graphics.FillEllipse(p.Brush, 15, 15, 10, 10);

            base.OnPaint(e);
        }

        int _points = 100;
        public int Points
        {
            get { return _points; }
        }

        Color m_Color = Color.Yellow;
        public Color Dot_Color
        {
            get
            {
                return m_Color;
            }
            set
            {
                m_Color = value;
            }
        }

        public new void Dispose()
        {
            _points = 0;
            Dispose(true);
        }

    }
}