using System;
using System.Drawing;

namespace Pacman.Characters
{
    public interface IBlock : IDisposable
    {
        Color Block_Color { get; set; }
    }
}