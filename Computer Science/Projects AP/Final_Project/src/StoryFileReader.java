import java.util.*;
import java.io.*;
public class StoryFileReader {
	private static File file = new File("C:\\Users\\1005939\\eclipse-workspace\\Final_Project\\src\\Story.txt"); 
	public static int lineLookedFor = 0;
	public StoryFileReader(int x, Location y) throws FileNotFoundException {
		Scanner sc = new Scanner(file);
		int startIndexOfLocation = 0, endIndexOfLocation = 0, startIndexOfDirections = 0, endIndexOfDirections = 0;

		while (sc.hasNextLine()) {
			String nextLine = sc.nextLine();
			if (Integer.parseInt(nextLine.substring(0,1)) == x) {
				while (nextLine.contains("|")) nextLine = nextLine.replace('|','\n');
				startIndexOfLocation = nextLine.indexOf('~');
				endIndexOfLocation = nextLine.lastIndexOf('~');
				startIndexOfDirections = nextLine.indexOf('%') + 1;
				endIndexOfDirections = nextLine.lastIndexOf('%');
				y.roomDescription = nextLine.substring(endIndexOfLocation + 1);
				y.roomTitle = nextLine.substring(startIndexOfLocation, endIndexOfLocation);
				y.directions = nextLine.substring(startIndexOfDirections, endIndexOfDirections);
				lineLookedFor = x;
				break;
			}
		}
		sc.close();

	}
}
