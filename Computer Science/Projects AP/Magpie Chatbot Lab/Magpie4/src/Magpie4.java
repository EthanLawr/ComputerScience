public class Magpie4
{
	public String getGreeting() {
		return "Hello, let's talk.";
	}

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
		else if (findKeyword(statement, "I want to", 0) >= 0) response = transformIWantToStatement(statement);
		else
		{
			int psn = findKeyword(statement, "you", 0);
			if (psn >= 0 && findKeyword(statement, "me", psn) >= 0) response = transformYouMeStatement(statement);
			else response = getRandomResponse();
		}
		
		return response;
	}

	private String transformIWantToStatement(String statement)
	{
		statement = statement.trim();
		String lastChar = statement.substring(statement.length() - 1);
		if (lastChar.equals(".")) statement = statement.substring(0, statement.length() - 1);
		int psn = findKeyword (statement, "I want to", 0);
		String restOfStatement = statement.substring(psn + 7).trim();
		return "What would it mean to " + restOfStatement + "?";
	}

	private String transformYouMeStatement(String statement)
	{
		statement = statement.trim();
		String lastChar = statement.substring(statement.length() - 1);
		if (lastChar.equals(".")) statement = statement.substring(0, statement.length() - 1);
		
		int psnOfYou = findKeyword (statement, "you", 0), psnOfMe = findKeyword (statement, "me", psnOfYou + 3);
		
		String restOfStatement = statement.substring(psnOfYou + 3, psnOfMe).trim();
		return "What makes you think that I " + restOfStatement + " you?";
	}
	
	private int findKeyword(String statement, String goal, int startPos)
	{
		String phrase = statement.trim().toLowerCase();
		goal = goal.toLowerCase();
		int psn = phrase.indexOf(goal, startPos);

		while (psn >= 0)
		{
			String before = " ", after = " ";
			if (psn > 0) before = phrase.substring(psn - 1, psn);
			if (psn + goal.length() < phrase.length()) after = phrase.substring(psn + goal.length(), psn + goal.length() + 1);
			if (((before.compareTo("a") < 0) || (before.compareTo("z") > 0)) && ((after.compareTo("a") < 0) || (after.compareTo("z") > 0)))
				return psn;

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