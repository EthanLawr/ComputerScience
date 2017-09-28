import info.gridworld.actor.ActorWorld;
import info.gridworld.grid.Location;
import java.awt.Color;

public class ZorroBugRunner
{
    public static void main( String args[] )
    {
        ActorWorld world = new ActorWorld( );
        ZorroBug bug1 = new ZorroBug(6);  //segment of Z = 6
        bug1.setColor(Color.ORANGE);

        world.add (new Location(7, 8), bug1 );

        world.show( );
    }
}