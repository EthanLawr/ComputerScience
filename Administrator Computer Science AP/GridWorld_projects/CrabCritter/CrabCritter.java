import info.gridworld.actor.Actor;
import info.gridworld.actor.Critter;
import info.gridworld.grid.*;
import java.util.ArrayList;

public class CrabCritter extends Critter
{
    public ArrayList<Actor> getActors( )
    {
        ArrayList<Actor> actors = new ArrayList<Actor>( );
        Grid<Actor> gr = getGrid( );
        Location loc = getLocation( );
        int dir = getDirection( );
        
        //Add the Actor directly in front of the Critter
        Location locFront = loc.getAdjacentLocation(dir);
        if( gr.isValid(locFront) )
            if( gr.get(locFront) != null )
                actors.add( gr.get(locFront) );
        
        //Add the Actor directly to the left-front of the Critter
        Location locLeftFront = loc.getAdjacentLocation(dir + Location.HALF_LEFT);
        if( gr.isValid(locLeftFront) )
            if( gr.get(locLeftFront) != null )
                actors.add( gr.get(locLeftFront) );
        
        //Add the Actor directly to the right-front of the Critter
        Location locRightFront = loc.getAdjacentLocation(dir + Location.HALF_RIGHT);
        if( gr.isValid(locRightFront) )
            if( gr.get(locRightFront) != null )
                actors.add( gr.get(locRightFront) );
                
        return actors;
    }
    
    public ArrayList<Location> getMoveLocations( )
    {
        ArrayList<Location> locs = new ArrayList<Location>( );
        Grid<Actor> gr = getGrid( );
        Location loc = getLocation( );
        int dir = getDirection( );        
        
        //Add Location to the left of the Critter if empty
        Location locLeft = loc.getAdjacentLocation(dir + Location.LEFT);
        if( gr.isValid(locLeft) )
        {
            if( gr.get(locLeft) == null )
                locs.add( locLeft );
        }
        
        //Add Location to the right of the Critter if empty
        Location locRight = loc.getAdjacentLocation(dir + Location.RIGHT);
        if( gr.isValid(locRight) )
        {
            if( gr.get(locRight) == null )
                locs.add( locRight );
        }                
        return locs;
    }
    
    public void makeMove(Location loc)
    {
        if( loc.equals(getLocation( )) )
        {
            //There is no place to move, so randomly select a left or right turn
            int r = (int)( 2 * Math.random( ) );
            if(r ==0)
                setDirection(getDirection( ) + Location.LEFT);
            else
                setDirection(getDirection( ) + Location.RIGHT);
        }
        else
            super.makeMove(loc);
    }   
}
