//
//
// Exit - represents an exit to a location
// 
// Last modification date : November 13, 1997
//
public class Exit implements java.io.Serializable
{
	// Numerical codes
	public static final int UNDEFINED = 0;
	public static final int NORTH = 1;
	public static final int SOUTH = 2;
	public static final int EAST  = 3;
	public static final int WEST  = 4;
	public static final int UP    = 5;
	public static final int DOWN  = 6;
	public static final int NORTHEAST = 7;
	public static final int NORTHWEST = 8;
	public static final int SOUTHEAST = 9;
	public static final int SOUTHWEST = 10;
	public static final int IN = 11;
	public static final int OUT = 12;

	// String codes	
	public static final String[] dirName = 
	{ 
		"UNDEFINED",
		"NORTH",
		"SOUTH",
		"EAST",
		"WEST",
		"UP",
		"DOWN",
		"NORTHEAST",
		"NORTHWEST",
		"SOUTHEAST",
		"SOUTHWEST",
		"IN",
		"OUT"
	};

	public static final String[] shortDirName = 
	{
		"NULL",
		"N",
		"S",
		"E",
		"W",
		"U",
		"D",
		"NE",
		"NW",
		"SE",
		"SW",
		"I",
		"O"		
	};

	// Member variables
	private Location m_leadsTo = null;
	private int m_direction;

	// Full name of direction eg SOUTHEAST
	private String m_directionName;

	// Shortened version of direction eg SE
	private String m_shortDirectionName;

	// Default constructor
	public Exit()
	{
		m_direction = Exit.UNDEFINED;
		m_leadsTo = null;
		m_directionName = dirName[UNDEFINED];
		m_shortDirectionName = shortDirName[UNDEFINED];
	}

	// Full constructor
	public Exit( int direction, Location leadsTo )
	{
		m_direction = direction;

		// Assign direction names
		if (direction <= dirName.length )
			m_directionName = dirName[m_direction];
		if (direction <= shortDirName.length )
			m_shortDirectionName = shortDirName[m_direction];

		// Assign location
		m_leadsTo = leadsTo;
	}

	// toString method
	public String toString()
	{
		return m_directionName;
	}

	// Assigns direction name
	public void setDirectionName( String dirname )
	{
		m_directionName = dirname;
	}

	// Returns direction name
	public String getDirectionName()
	{
		return m_directionName;
	}

	// Assigns short direction name
	public void setShortDirectionName ( String shortName )
	{
		m_shortDirectionName = shortName;
	}

	// Returns short direction name
	public String getShortDirectionName ()
	{
		return m_shortDirectionName;
	}

	// Assigns location
	public void setLeadsTo ( Location leadsTo )
	{
		m_leadsTo = leadsTo;
	}

	// Returns location
	public Location getLeadsTo (  )
	{
		return m_leadsTo;
	}

}

