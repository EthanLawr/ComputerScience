//This class will not compile until the BasicBug class first compiles.
import info.gridworld.actor.ActorWorld;
import info.gridworld.grid.Location;
import java.awt.Color;
import info.gridworld.actor.Rock;
public class BasicBugRunner
{
          public static void main(String args[])
          {
                ActorWorld world = new ActorWorld( );
                BasicBug bug1 = new BasicBug( );
                bug1.setColor(Color.ORANGE);

                Rock rock1 = new Rock( );
                rock1.setColor(Color.BLACK);

                world.add(new Location(5,3), bug1);
                world.add(new Location(1, 3), rock1);
                world.show( );
          }
}
