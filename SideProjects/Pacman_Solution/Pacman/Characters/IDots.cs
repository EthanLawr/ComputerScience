using System;
using System.Drawing;

namespace Pacman.Characters
{
    public interface IDots : IDisposable
    {
        int Points { get; }
        Color Dot_Color { get; set; }
    }
}