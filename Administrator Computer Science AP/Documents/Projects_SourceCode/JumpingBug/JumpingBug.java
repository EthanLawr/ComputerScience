import info.gridworld.grid.Location;
import info.gridworld.grid.Grid;
import info.gridworld.actor.*;

public class JumpingBug extends Bug
{
    //state variables
    private int numTurnDegrees;
    private Location moveHere;

    public void act()
    {
        if( canMove( ) )
        {
            move( );
        }
        else
        {
            turn( );
        }
    }
    
    public void turn()
    {
       setDirection( getDirection( ) + numTurnDegrees ); 
    }
    
    public boolean canMove()
    {
        Grid<Actor> gr = getGrid();
        if(gr==null)
            return false;
        Location loc = getLocation( );
        Location adjacentLoc = loc.getAdjacentLocation( getDirection( ) );
        if( !gr.isValid(adjacentLoc) )
        {
            //Off the grid
            numTurnDegrees = 225;
            return false;
        }
        
        Actor adjacentNeighbor = gr.get(adjacentLoc);
        if( (adjacentNeighbor == null) || (adjacentNeighbor instanceof Flower) )
        {
            //Ok to move to adjacent location
            moveHere = adjacentLoc;
            return true;
        }
        else
        {
            //blocked by another bug or rock,... see if we can jump over it
            Location jumpLoc = adjacentLoc.getAdjacentLocation( getDirection( ) );
            if( !gr.isValid(jumpLoc) )
            {
                //Off the grid
                numTurnDegrees = 135;
                return false;
            }
            
            Actor jumpObject = gr.get(jumpLoc);
            if( (jumpObject == null) || (jumpObject instanceof Flower) )
            {
                //Ok to jump to this new location
                moveHere = jumpLoc;
                return true;
            }
            else
            {
                numTurnDegrees = 45;
                return false;                
            }
        }
    }
    
    public void move( )
    {
        Grid<Actor> gr = getGrid();
        if( gr==null )
            return;
        Location oldLoc = getLocation( );
        moveTo(moveHere);
        Flower flower = new Flower( getColor( ) );
        flower.putSelfInGrid(gr, oldLoc);   
    }
}