import java.util.*;
import java.io.*;
public class StoryFileReader {
	private static File StoryFile = new File("src/Story.txt");
	private static File Progress = new File("src/Progress.txt");
	public static int lineLookedFor = 0;
	@SuppressWarnings("static-access")
	public StoryFileReader(int x, Location y) throws FileNotFoundException {
		Scanner sc = new Scanner(Progress);
		int startIndexOfLocation = 0, endIndexOfLocation = 0, startIndexOfDirections = 0, endIndexOfDirections = 0;
		while (sc.hasNextLine()) {
			String nextLine = sc.nextLine();
			
			if (Integer.parseInt(nextLine.substring(0,1)) == x) {
				Location.rawDesc = nextLine;
				while (nextLine.contains("|")) nextLine = nextLine.replace('|','\n');
				startIndexOfLocation = nextLine.indexOf('~');
				endIndexOfLocation = nextLine.lastIndexOf('~');
				startIndexOfDirections = nextLine.indexOf('%') + 1;
				endIndexOfDirections = nextLine.lastIndexOf('%');
				if (nextLine.contains("+")) {
					y.stateOfRoom = Integer.parseInt(nextLine.substring(2, 3));
				}
				y.roomDescription = nextLine.substring(endIndexOfLocation + 1);
				y.roomTitle = nextLine.substring(startIndexOfLocation, endIndexOfLocation);
				y.directions = nextLine.substring(startIndexOfDirections, endIndexOfDirections);

				//System.out.print(Location.rawData);
				lineLookedFor = x;
				break;
			}
		}
		sc.close();

	}
	public StoryFileReader() throws IOException {
		Scanner sc = new Scanner(StoryFile);

		String nextLine = "";
		while (sc.hasNextLine()) {
			nextLine += sc.nextLine() + "\n";
		}
		FileWriter writer = new FileWriter(Progress);
        writer.write(nextLine);
        writer.close();
		sc.close();

	}
	public static void ResetProgressionPartial() throws IOException {
		Scanner sc = new Scanner(StoryFile);

		String nextLine = "";
		while (sc.hasNextLine()) {
			nextLine += sc.nextLine() + "\n";
		}
		FileWriter writer = new FileWriter(Progress);
		writer.write(nextLine);
		writer.close();
		sc.close();
		Player.randomlyGeneratedRoomsEntered = 0;
		Player.Inventory = new ArrayList < String > ();
		Player.weapon = "Hands";
		Player.armor = "None";
	}
	public static void OverWriteLine(String Replaced, String Replacer) throws IOException{
		Scanner sc = new Scanner(Progress);

		String nextLine = "";
		while (sc.hasNextLine()) {
			nextLine += sc.nextLine() + "\n";
		}
		sc.close();
		nextLine = nextLine.replace(Replaced, Replacer);
		FileWriter writer = new FileWriter(Progress);
        writer.write(nextLine);
        writer.close();
	}
}