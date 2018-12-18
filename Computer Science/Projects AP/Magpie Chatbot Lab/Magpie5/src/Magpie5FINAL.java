import java.util.Random;

public class Magpie5FINAL
{
	// This program will be a chatbot for the user
    // By Ethan Lawrence 12/18/2018
	// elawrence152@gmail.com
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
		else if (findKeyword(statement, "I want", 0) >= 0) response = transformIWantStatement(statement);
		else 
		{
			int psn = findKeyword(statement, "you", 0);
			if (psn >= 0 && findKeyword(statement, "me", psn) >= 0) response = transformYouMeStatement(statement);
			else
			{
				psn = findKeyword(statement, "i", 0);
				if (psn >= 0 && findKeyword(statement, "you", psn) >= 0) response = transformIYouStatement(statement);
				else response = getRandomResponse();
			}
		}
		
		return response;
	}

	private String transformIWantToStatement(String statement)
	{
		statement = statement.trim();
		String lastChar = statement.substring(statement.length() - 1);
		if (lastChar.equals(".")) statement = statement.substring(0, statement.length() - 1);
		int psn = findKeyword (statement, "I want to", 0);
		String restOfStatement = statement.substring(psn + 9).trim();
		return "What would it mean to " + restOfStatement + "?";
	}
	
	private String transformIWantStatement(String statement)
	{
		statement = statement.trim();
		String lastChar = statement.substring(statement.length() - 1);
		if (lastChar.equals(".")) statement = statement.substring(0, statement.length() - 1);
		int psn = findKeyword (statement, "I want", 0);
		String restOfStatement = statement.substring(psn + 6).trim();
		return "Would you really be happy if you had " + restOfStatement + "?";
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
	
	private String transformIYouStatement(String statement)
	{
		statement = statement.trim();
		String lastChar = statement.substring(statement.length() - 1);
		if (lastChar.equals(".")) statement = statement.substring(0, statement.length() - 1);
		
		int psnOfI = findKeyword (statement, "I", 0), psnOfYou = findKeyword (statement, "you", psnOfI);
		
		String restOfStatement = statement.substring(psnOfI + 1, psnOfYou).trim();
		return "Why do you " + restOfStatement + " me?";
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
		Random r = new Random();
		return randomResponses[r.nextInt(randomResponses.length)];
	}
	
	private String[] randomResponses = {"Interesting, tell me more","Hmmm.","Do you really think so?","You don't say."};
}