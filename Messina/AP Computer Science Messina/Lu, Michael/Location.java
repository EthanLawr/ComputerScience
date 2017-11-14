import java.util.Vector;
import java.util.Enumeration;

//
//
// Location - represents a gaming location
//
// Last modification date : November 13, 1997
//
public class Location implements java.io.Serializable
{
	// Member variables
	private String m_roomTitle;
	private String m_roomDescription;
	private Vector m_vecExits;

	// Blank constructor
	public Location()
	{
		// Blank title + description
		m_roomTitle = new String ();
		m_roomDescription = new String();
		m_vecExits = new Vector();
	}

	// Partial constructor
	public Location( String title )
	{
		// Assign title
		m_roomTitle = title;

		// Blank description
		m_roomDescription = new String();

		// Blank exits
		m_vecExits = new Vector();
	}

	// Full constructor
	public Location( String title, String description )
	{
		// Assign title + description
		m_roomTitle = title;
		m_roomDescription = description;

		// Blank exits
		m_vecExits = new Vector();
	}

	// toString method
	public String toString()
	{
		return m_roomTitle;
	}

	// Adds an exit to this location
	public void addExit ( Exit exit )
	{
		m_vecExits.addElement (exit);
	}

	// Removes an exit from this location
	public void removeExit ( Exit exit )
	{
		if (m_vecExits.contains (exit))
		{
			m_vecExits.removeElement (exit);
		}
	}

	// Returns a vector of exits
	public Vector getExits ()
	{
		// Return a clone, as we don't want an external
		// object to modify our original vector
		return (Vector) m_vecExits.clone();
	}
	
	// Returns location title
	public String getTitle()
	{
		return m_roomTitle;
	}

	// Assigns location title
	public void setTitle( String roomTitle )
	{
		m_roomTitle = roomTitle;
	}

	// Returns location description
	public String getDescription()
	{
		return m_roomDescription;
	}

	// Assigns location description
	public void setDescription( String roomDescription )
	{
		m_roomDescription = roomDescription;
	}
}

