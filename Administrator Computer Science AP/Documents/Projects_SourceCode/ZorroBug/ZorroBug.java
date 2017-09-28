import info.gridworld.actor.Bug;
import info.gridworld.grid.Location;

public class ZorroBug extends Bug
{
    //state variables
    private int segmentLength;
    private int steps;
    private int segment; //determines which segment of the Z we are on

    //constructor
    public ZorroBug(int length)
    {
        setDirection(Location.EAST);  //point bug east
        segmentLength = length;
        steps = 0;
        segment = 0; //indicates which segment we are on
    }

    public void act()
    {
        switch(segment)
        {
            case 0: //top part of Z
                motionHandler(Location.SOUTHWEST);  //turn SOUTHEAST at end of this segment
                break;
            case 1: //diagonal part of Z
                motionHandler(Location.EAST);
                break;
            case 2: //bottom part of Z
                motionHandler(Location.EAST);
        }        
    }
    
    private void motionHandler(int newDirection)
    {
                if( (steps < segmentLength) && ( canMove( ) ) )
                {
                    move( );
                    steps++;
                }
                else
                {
                    setDirection(newDirection);
                    steps = 0;
                    segment++;
                }        
    }
}