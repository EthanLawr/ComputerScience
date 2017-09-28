import info.gridworld.actor.ActorWorld;
import info.gridworld.grid.Location;
import java.awt.Color;

public class BoxBugRunner
{
    public static void main( String args[] )
    {
        ActorWorld world = new ActorWorld( );
        BoxBug bug1 = new BoxBug(6);  //side of box = 6
        bug1.setColor(Color.ORANGE);

        world.add (new Location(7, 8), bug1 );

        world.show( );
    }
}
