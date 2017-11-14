import java.util.Scanner;

// A simple class to run the Magpie2 class.
// by Mr.Messina  questions/comments jmessina@crsd.org12/3/15

public class MagpieRunner2
{

	// Creates a Magpie2, give it user input, and print its replies.
	
	public static void main(String[] args)
	{
		Magpie2 maggie = new Magpie2();
		
		System.out.println (maggie.getGreeting());
		Scanner in = new Scanner (System.in);
		String statement = in.nextLine();
		
		while (!statement.equals("Bye"))
		{
			System.out.println (maggie.getResponse(statement));
			statement = in.nextLine();
		}
	}

}
