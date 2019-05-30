import java.util.*;
import java.io.*;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
public class StoryFileReader {
	private static File StoryFile = new File("C:\\Users\\1005939\\eclipse-workspace\\Final_Project\\src\\Story.txt");
	private static File Progress = new File("C:\\Users\\1005939\\eclipse-workspace\\Final_Project\\src\\Progress.txt");
	public static int lineLookedFor = 0;
	public StoryFileReader(int x, Location y) throws FileNotFoundException {
		Scanner sc = new Scanner(Progress);
		int startIndexOfLocation = 0, endIndexOfLocation = 0, startIndexOfDirections = 0, endIndexOfDirections = 0, 
				startIndexOfOperations = 0, endIndexOfOperations = 0;

		while (sc.hasNextLine()) {
			String nextLine = sc.nextLine();
			if (Integer.parseInt(nextLine.substring(0,1)) == x) {
				while (nextLine.contains("|")) nextLine = nextLine.replace('|','\n');
				startIndexOfLocation = nextLine.indexOf('~');
				endIndexOfLocation = nextLine.lastIndexOf('~');
				startIndexOfDirections = nextLine.indexOf('%') + 1;
				endIndexOfDirections = nextLine.lastIndexOf('%');
				if (nextLine.contains("+")) {
					startIndexOfOperations = nextLine.indexOf('+') + 1;
					endIndexOfOperations = nextLine.lastIndexOf('+');
					y.stateOfRoom = Integer.parseInt(nextLine.substring(startIndexOfOperations, endIndexOfOperations));
				}
				y.roomDescription = nextLine.substring(endIndexOfLocation + 1);
				y.roomTitle = nextLine.substring(startIndexOfLocation, endIndexOfLocation);
				y.directions = nextLine.substring(startIndexOfDirections, endIndexOfDirections);
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
	public static void OverWriteLine(String Replaced, String Replacer){
		File fileToBeModified = new File(Progress.getAbsolutePath());
		BufferedReader sc = null;
        
        FileWriter writer = null;
		try {
			sc = new BufferedReader(new FileReader(fileToBeModified));

			String line = sc.readLine();
	        String nextLine = "";
	        while (line != null) 
	        {
				nextLine += line + "\n";
			}
			nextLine.replaceAll(Replaced, Replacer);
			writer = new FileWriter(fileToBeModified);
	        writer.write(nextLine);
		} catch (IOException e) {
            e.printStackTrace();
        } finally {
            try
            {
            	sc.close();
                writer.close();
            } 
            catch (IOException e) 
            {
                e.printStackTrace();
            }
        }
		
		
	}
}
