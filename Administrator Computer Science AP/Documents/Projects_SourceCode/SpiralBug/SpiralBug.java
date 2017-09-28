import info.gridworld.actor.Bug;
public class SpiralBug extends Bug
{
    //state variables
    private int sideLength;
    private int steps;

    //constructor
    public SpiralBug(int length)
    {
        sideLength = length;
        steps = 0;
    }

    public void act()
    {
        if( (steps < sideLength) && ( canMove( ) ) )
        {
            move( );
            steps++;
        }
        else
        {
            turn( );
            turn( );
            steps = 0;
            sideLength++;
        }
    }
}