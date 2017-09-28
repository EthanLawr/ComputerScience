import info.gridworld.actor.*;
import info.gridworld.grid.Location;
import java.awt.Color;

public class JumpingBugRunner
{
    public static void main( String args[] )
    {
        ActorWorld world = new ActorWorld( );
        JumpingBug bug1 = new JumpingBug( );
        bug1.setColor(Color.ORANGE);
        world.add ( new Location(7, 8), bug1 );
                
        world.add( new Location(4, 8), new Rock( ) );
        world.add( new Location(3, 5), new Rock( ) );
        world.add( new Location(4, 4), new Rock( ) );

        world.show( );
    }
}