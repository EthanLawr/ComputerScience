import java.util.Scanner;

public class MagpieRunner4
{

	public static void main(String[] args)
	{
		Magpie4FINAL maggie = new Magpie4FINAL();
		
		System.out.println (maggie.getGreeting());
		Scanner in = new Scanner (System.in);
		String statement = in.nextLine();
		
		while (!statement.equals("Bye"))
		{
			System.out.println (maggie.getResponse(statement));
			statement = in.nextLine();
		}
		while (statement.equals("Bye")) {
			System.out.println("Bye!");
			break;
		}
	}

}

