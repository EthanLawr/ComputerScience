import java.util.Scanner;

public class MagpieRunner3
{

	public static void main(String[] args)
	{
		Magpie3FINAL maggie = new Magpie3FINAL();
		
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

