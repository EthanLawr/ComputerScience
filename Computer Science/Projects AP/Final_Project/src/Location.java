
public class Location
{
	// Member variables
	public String roomTitle, roomDescription, directions;
	public static String[] directionsArray;
	public static final String[] DirectionName = 
		{"north","south","east","west","up","down","northeast","northwest","southeast","southwest"},
		shortDirName = {"n","s","e","w","u","d","ne","nw","se","sw"},
		allDirectionNames = {"north","south","east","west","up","down",
				"northeast","northwest","southeast","southwest","n","s","e","w","u","d","ne","nw","se","sw"};
	public static int stateOfRoom = 0;
	public Location() {
	}
	public void DirectionDisplay() {
		System.out.print("\nYou can move in the following directions: ");
		directionsArray = directions.split(",");
	    for (String s : directionsArray) System.out.print(s + " ");
	}
	public static boolean MovementCheck(String x, String DirectionCheckingFor) {
		if (DirectionCheckingFor.equals("north") && (x.trim().equals("north") || x.trim().equals("n"))) return true;
		else if (DirectionCheckingFor.equals("south") && (x.trim().equals("south") || x.trim().equals("s"))) return true;
		else if (DirectionCheckingFor.equals("east") && (x.trim().equals("east") || x.trim().equals("e"))) return true;
		else if (DirectionCheckingFor.equals("west") && (x.trim().equals("west") || x.trim().equals("w"))) return true;
		else if (DirectionCheckingFor.equals("up") && (x.trim().equals("up") || x.trim().equals("u"))) return true;
		else if (DirectionCheckingFor.equals("down") && (x.trim().equals("down") || x.trim().equals("d"))) return true;
		else if (DirectionCheckingFor.equals("northeast") && (x.trim().equals("northeast") || x.trim().equals("ne"))) return true;
		else if (DirectionCheckingFor.equals("northwest") && (x.trim().equals("northwest") || x.trim().equals("nw"))) return true;
		else if (DirectionCheckingFor.equals("southeast") && (x.trim().equals("southeast") || x.trim().equals("se"))) return true;
		else if (DirectionCheckingFor.equals("southwest") && (x.trim().equals("southwest") || x.trim().equals("sw"))) return true;
		else return false;
	}
	
}