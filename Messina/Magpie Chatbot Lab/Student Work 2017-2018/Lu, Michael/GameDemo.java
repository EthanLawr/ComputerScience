import java.io.*;
import java.util.*;

//
//
// GameDemo
//
// Demonstrates a simple gaming system, loaded from
// a persistent object store.
//
// Last modification date : December 20, 1997
//
class GameDemo 
{
	private static final String filename = "gameworld.dat";

	// GameWorld
	private GameWorld game;

	// Game demo constructor
	public GameDemo() throws Exception
	{		
		// Create a file input stream
		FileInputStream fin = new FileInputStream(filename);

		// Create an object input stream
		ObjectInputStream objectIn = new ObjectInputStream(fin);

		// Read an object in from object store, and cast it to a GameWorld
		game = (GameWorld) objectIn.readObject();

		// Set the object stream to standard output		
		game.setOutputStream ( System.out, 40 );
	}

	public static void main(String args[]) throws Exception
	{
		new GameDemo().play();
	}

	public void play()
	{
		String command = null;
		boolean validCommand = false;

		// Create a data input stream
		DataInputStream din = new DataInputStream ( System.in );

		for (;;)
		{
			// Show location
			game.showLocation();

			// Get user input
			try
			{
				command = din.readLine();
				
				// Print a new line
				System.out.println();
			}
			catch (IOException e)
			{
			}

			// By default, we haven't found a valid command
			validCommand = false;

			// Parse user input
			if (command.length() == 0)
			{
				System.out.println ("Huh? Invalid command!");
				continue;
			}

			// Convert to uppercase for comparison
			command = command.toUpperCase();

			// Search for an exit match
			for (Enumeration e = game.getCurrentLocation().getExits().elements(); e.hasMoreElements();)
			{
				Exit an_exit = (Exit) e.nextElement();

				if ( (an_exit.getDirectionName().compareTo(command) == 0) ||
					 (an_exit.getShortDirectionName().compareTo(command) == 0 )
				   )
				{
					// Set location to the location pointed to by exit
					game.setCurrentLocation( an_exit.getLeadsTo() );

					// Valid command encountered
					validCommand = true;

					// No need to search exits anymore
					break;
				}				
			}

			// Check to see if user wants to quit
			if (command.compareTo( "QUIT" ) == 0)
			{
				System.out.println ("Okay. Bye!");
				System.exit(0);
			}

			// If no valid commands, warn the user is invalid
			if (!validCommand)
			{
				System.out.println ("Huh? Invalid direction!");
				System.out.println ();
			}
		}
	}
}

