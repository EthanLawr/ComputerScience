import info.gridworld.actor.*;
import info.gridworld.grid.Location;
import java.awt.Color;

public class ChameleonCritterRunner
{
    public static void main( String args[] )
    {
        ActorWorld world = new ActorWorld( );
        ChameleonCritter cc1 = new ChameleonCritter( );
        cc1.setColor(Color.ORANGE);
        world.add ( new Location(5, 6), cc1 );
        
        world.add( new Location(4, 8), new Rock(Color.GREEN) );
        world.add( new Location(3, 5), new Rock(Color.BLUE) );
        world.add( new Location(4, 4), new Rock(Color.RED) );

        world.show( );
    }
}