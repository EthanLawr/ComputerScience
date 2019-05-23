public class Movement 
{
	// Numerical codes
	public static final int UNDEFINED = 0, NORTH = 1, SOUTH = 2, EAST  = 3, WEST  = 4, UP    = 5, 
			DOWN  = 6, NORTHEAST = 7, NORTHWEST = 8, SOUTHEAST = 9, SOUTHWEST = 10;
	// String codes	
	public static final String[] DirectionName = 
	{"undefined","north","south","east","west","up","down","northeast","northwest","southeast","southwest"};
	public static final String[] shortDirName = 
	{"null","n","s","e","w","u","d","ne","nw","se","sw","i","o"};

	// Member variables
	private Location m_leadsTo = null;
	private int m_direction;

	// Full name of direction eg SOUTHEAST
	private String m_directionName, m_shortDirectionName;

	// Default constructor
	public Movement()
	{
		m_direction = Movement.UNDEFINED;
		m_leadsTo = null;
		m_directionName = DirectionName[UNDEFINED];
		m_shortDirectionName = shortDirName[UNDEFINED];
	}

	// Full constructor
	public Movement(int direction, Location leadsTo)
	{
		m_direction = direction;
		// Assign direction names
		if (direction <= DirectionName.length )
			m_directionName = DirectionName[m_direction];
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
	public void setDirectionName(String x)
	{
		m_directionName = x;
	}

	// Returns direction name
	public String getDirectionName()
	{
		return m_directionName;
	}

	// Assigns short direction name
	public void setShortDirectionName(String x)
	{
		m_shortDirectionName = x;
	}

	// Returns short direction name
	public String getShortDirectionName()
	{
		return m_shortDirectionName;
	}

	// Assigns location
	public void setLeadsTo(Location x)
	{
		m_leadsTo = x;
	}

	// Returns location
	public Location getLeadsTo()
	{
		return m_leadsTo;
	}

}
