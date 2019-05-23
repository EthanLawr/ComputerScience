import java.nio.file.Paths;
import java.util.*;
import java.io.*;
public class StoryFileReader {
	private static File file = new File("C:\\Users\\1005939\\eclipse-workspace\\Final_Project\\src\\Story.txt"); 
	private static int lineLookedFor = 0;
	public StoryFileReader(int x, Location y) throws FileNotFoundException {
		Scanner sc = new Scanner(file);
		int startIndexOfLocation = 0, endIndexOfLocaiton = 0;

		while (sc.hasNextLine()) {
			String nextLine = sc.nextLine();
			if (Integer.parseInt(nextLine.substring(0,1)) == x) {
				while (nextLine.contains("|")) nextLine = nextLine.replace('|','\n');
				startIndexOfLocation = nextLine.indexOf('~');
				endIndexOfLocaiton = nextLine.lastIndexOf('~');
				y.roomDescription = nextLine.substring(endIndexOfLocaiton + 1);
				y.roomTitle = nextLine.substring(startIndexOfLocation, endIndexOfLocaiton);
				break;
			} else {
				ArrayList<String> s = new ArrayList<String>();
				s.add("x");
				for (int i = 0; i < s.size(); i++) System.out.print(s.get(0));
				
			}
		}
		sc.close();

	}
}
