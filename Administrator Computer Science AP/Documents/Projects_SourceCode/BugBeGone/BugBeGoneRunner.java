import info.gridworld.actor.ActorWorld;
import info.gridworld.grid.Location;
import java.awt.Color;
import info.gridworld.actor.Rock;

public class BugBeGoneRunner
{
    public static void main( String args[] )
    {
        ActorWorld world = new ActorWorld( );
        BugBeGone bug1 = new BugBeGone( );
        bug1.setColor(Color.ORANGE);
        world.add ( new Location(7, 8), bug1 );
        
        Rock rck1 = new Rock( );
        world.add( new Location(4, 8), rck1 );

        world.show( );
    }
}