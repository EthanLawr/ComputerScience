
public class Location
{
	// Member variables
	public String roomTitle, roomDescription, directions;
	public String[] directionsArray;
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
	public boolean MovementCheck(String x, String DirectionCheckingFor) {
		if (DirectionCheckingFor == "north" && (x.equals("north") || x.equals("n"))) return true;
		else if (DirectionCheckingFor == "south" && (x.equals("south") || x.equals("s"))) return true;
		else if (DirectionCheckingFor == "east" && (x.equals("east") || x.equals("e"))) return true;
		else if (DirectionCheckingFor == "west" && (x.equals("west") || x.equals("w"))) return true;
		else if (DirectionCheckingFor == "up" && (x.equals("up") || x.equals("u"))) return true;
		else if (DirectionCheckingFor == "down" && (x.equals("down") || x.equals("d"))) return true;
		else if (DirectionCheckingFor == "northeast" && (x.equals("northeast") || x.equals("ne"))) return true;
		else if (DirectionCheckingFor == "northwest" && (x.equals("northwest") || x.equals("nw"))) return true;
		else if (DirectionCheckingFor == "southeast" && (x.equals("southeast") || x.equals("se"))) return true;
		else if (DirectionCheckingFor == "southwest" && (x.equals("southwest") || x.equals("sw"))) return true;
		else return false;
	}
	
}