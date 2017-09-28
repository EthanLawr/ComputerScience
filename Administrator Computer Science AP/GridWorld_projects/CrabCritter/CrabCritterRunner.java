import info.gridworld.actor.*;
import info.gridworld.grid.Location;
import java.awt.Color;

public class CrabCritterRunner
{
    public static void main( String args[] )
    {
        ActorWorld world = new ActorWorld( );
        CrabCritter cc1 = new CrabCritter( );
        cc1.setColor(Color.ORANGE);
        world.add ( new Location(4, 5), cc1 );
        
        world.add( new Location(3, 6), new Rock(Color.GREEN) );
        world.add( new Location(3, 5), new Bug(Color.BLUE) );
        world.add( new Location(4, 4), new Rock(Color.RED) );

        world.show( );
    }
}