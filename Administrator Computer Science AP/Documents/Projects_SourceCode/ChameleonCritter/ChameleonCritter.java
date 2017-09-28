import info.gridworld.actor.Actor;
import info.gridworld.actor.Critter;
import info.gridworld.grid.Location;
import java.util.ArrayList;

public class ChameleonCritter extends Critter
{
    public void processActors(ArrayList<Actor> actors)
    {
        int n = actors.size( );
        if(n == 0)
            return;
        int r = (int)(Math.random( ) * n);
        
        Actor other = actors.get(r);
        setColor(other.getColor());
    }
    
    public void makeMove(Location loc)
    {
        int dir = getLocation().getDirectionToward(loc);
        setDirection(dir);
        super.makeMove(loc);
    }
}
