using System.Drawing;
using System.Windows.Forms;

namespace Pacman.Characters
{
    public class Block : Control, IBlock
    {
        public Block()
        {
            BackColor = Block_Color;
        }

        public Block(int width, int height)
            : this()
        {
            Width = width;
            Height = height;
        }

        public Block(int width, int height, Point location)
            : this(width, height)
        {
            Location = location;
        }

        Color m_Block_Color = Color.Brown;
        public Color Block_Color
        {
            get
            {
                return m_Block_Color;
            }
            set
            {
                m_Block_Color = value;
            }
        }
    }
}