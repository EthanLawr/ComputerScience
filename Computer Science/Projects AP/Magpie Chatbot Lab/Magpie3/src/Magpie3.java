/**
 * A program to carry on conversations with a human user.
 * This version: 
 * <ul><li>
 *    Uses advanced search for keywords 
 * </li></ul> 
 *    
 * @author Laurie White
 * @version April 2012
 */
public class Magpie3
{
	/**
	 * Get a default greeting
	 * 
	 * @return a greeting
	 */
	public String getGreeting() {
		return "Hello, let's talk.";
	}

	/**
	 * Gives a response to a user statement
	 * 
	 * @param statement
	 *            the user statement
	 * @return a response based on the rules given
	 */
	public String getResponse(String statement)
	{
		String response = "";
		if (findKeyword(statement, "no") >= 0) response = "Why so negative?";
		else if (findKeyword(statement, "mother") >= 0 || findKeyword(statement, "father") >= 0 || findKeyword(statement, "sister") >= 0 || 
				findKeyword(statement, "brother") >= 0) response = "Tell me more about your family.";
		else if (findKeyword(statement, "dog") >= 0 || findKeyword(statement, "cat") >= 0) response = "Tell me more about your pets";
		else if (findKeyword(statement, "messina") >= 0 || findKeyword(statement, "joe") >= 0) response = "He sounds like a good teacher.";
		else if (statement.trim().length() == 0) response = "Say something, please.";
		else if (findKeyword(statement, "bread") >= 0) response = "Let's get this bread!";
		else if (findKeyword(statement, "ai") >= 0 || findKeyword(statement, "bot") >= 0 || findKeyword(statement, "computer") >= 0) 
			response = "I'm not a computer!";
		else response = getRandomResponse();
		return response;
	}

	private int findKeyword(String statement, String goal,
			int startPos)
	{
		String phrase = statement.trim().toLowerCase();
		goal = goal.toLowerCase();

		// The only change to incorporate the startPos is in
		// the line below
		int psn = phrase.indexOf(goal, startPos);

		// Refinement--make sure the goal isn't part of a
		// word
		while (psn >= 0)
		{
			// Find the string of length 1 before and after
			// the word
			String before = " ", after = " ";
			if (psn > 0) before = phrase.substring(psn - 1, psn);
			if (psn + goal.length() < phrase.length()) after = phrase.substring(psn + goal.length(), psn + goal.length() + 1);

			// If before and after aren't letters, we've
			// found the word
			if (((before.compareTo("a") < 0) || (before.compareTo("z") > 0)) && ((after.compareTo("a") < 0) || (after.compareTo("z") > 0)))
				return psn;

			// The last position didn't work, so let's find
			// the next, if there is one.
			psn = phrase.indexOf(goal, psn + 1);

		}

		return -1;
	}

	private int findKeyword(String statement, String goal)
	{
		return findKeyword(statement, goal, 0);
	}

	private String getRandomResponse()
	{
		final int NUMBER_OF_RESPONSES = 4;
		double r = Math.random();
		int whichResponse = (int) (r * NUMBER_OF_RESPONSES);
		String response = "";

		if (whichResponse == 0) response = "Interesting, tell me more.";
		else if (whichResponse == 1) response = "Hmmm.";
		else if (whichResponse == 2) response = "Do you really think so?";
		else if (whichResponse == 3) response = "You don't say.";


		return response;
	}

}