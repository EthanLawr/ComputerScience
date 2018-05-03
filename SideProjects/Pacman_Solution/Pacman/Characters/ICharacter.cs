using System;

namespace Pacman.Characters
{
    public enum CharacterType
    {
        Packman,
        Enemy
    }

    public enum MovementWay
    {
        Up,
        Down,
        Left,
        Right
    }

    public interface ICharacter : IDisposable
    {
        int TotalPoints { get; set; }
        int Speed { get; set; }
        CharacterType Type { get; }
        void Move(MovementWay way);
    }
}