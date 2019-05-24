import java.util.ArrayList;

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
	public Location() {
	}
	public void DirectionDisplay() {
		System.out.print("\nYou can move in the following directions: ");
		directionsArray = directions.split(",");
	    for (String s : directionsArray) System.out.print(s + " ");
	}
}