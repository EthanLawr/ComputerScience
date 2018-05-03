using System.Drawing;
using System.Windows.Forms;

namespace Pacman.Characters
{
    public sealed class DrawCharacter
    {
        public static void Draw(ref PaintEventArgs e, CharacterType type, MovementWay way = MovementWay.Right)
        {
            switch (type)
            {
                case CharacterType.Packman:
                    e.Graphics.Clear(SystemColors.Control);
                    e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(0, 0, 40, 40));
                    switch (way)
                    {
                        case MovementWay.Right:
                            e.Graphics.FillPolygon(SystemBrushes.Control, new Point[] { new Point(40, 0), new Point(20, 20), new Point(40, 40) });
                            e.Graphics.FillEllipse(Brushes.Black, new Rectangle(10, 10, 5, 5));
                            break;
                        case MovementWay.Left:
                            e.Graphics.FillPolygon(SystemBrushes.Control, new Point[] { new Point(0, 0), new Point(20, 20), new Point(0, 40) });
                            e.Graphics.FillEllipse(Brushes.Black, new Rectangle(20, 10, 5, 5));
                            break;

                        case MovementWay.Up:
                            e.Graphics.FillPolygon(SystemBrushes.Control, new Point[] { new Point(0, 0), new Point(20, 20), new Point(40, 0) });
                            e.Graphics.FillEllipse(Brushes.Black, new Rectangle(10, 20, 5, 5));
                            break;

                        case MovementWay.Down:
                            e.Graphics.FillPolygon(SystemBrushes.Control, new Point[] { new Point(0, 40), new Point(20, 20), new Point(40, 40) });
                            e.Graphics.FillEllipse(Brushes.Black, new Rectangle(10, 10, 5, 5));
                            break;

                    }
                    break;

                case CharacterType.Enemy:
                    e.Graphics.FillEllipse(Brushes.Blue, new Rectangle(0, 0, 40, 50));
                    e.Graphics.FillEllipse(Brushes.LightYellow, new Rectangle(10, 10, 5, 5));
                    e.Graphics.FillEllipse(Brushes.LightYellow, new Rectangle(25, 10, 5, 5));
                    e.Graphics.FillPolygon(SystemBrushes.Control,
                                            new Point[] {
                                                    new Point(0, 40),
                                                    new Point(5, 30),
                                                    new Point(10, 40),
                                                    new Point(15, 30),
                                                    new Point(20, 40),
                                                    new Point(25, 30),
                                                    new Point(30, 40),
                                                    new Point(35, 30),
                                                    new Point(40, 40),});

                    break;
            }
        }

    }
}