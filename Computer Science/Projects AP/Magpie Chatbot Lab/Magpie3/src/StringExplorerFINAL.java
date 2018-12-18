public class StringExplorerFINAL
{
	// This program will be a enter strings and modify them
    // By Ethan Lawrence 12/18/2018
	// elawrence152@gmail.com
	public static void main(String[] args)
	{
		String sample = "The quick brown fox jumped over the lazy dog.";
		
		int position = sample.indexOf("quick");
		System.out.println ("sample.indexOf(\"quick\") = " + position);
		
		String lowerCase = sample.toLowerCase();
		System.out.println ("sample.toLowerCase() = " + lowerCase);
		System.out.println ("After toLowerCase(), sample = " + sample);
		
		int notFoundPsn = sample.indexOf("slow");
		System.out.println("sample.indexOf(\"slow\") = " + notFoundPsn);
	}
}