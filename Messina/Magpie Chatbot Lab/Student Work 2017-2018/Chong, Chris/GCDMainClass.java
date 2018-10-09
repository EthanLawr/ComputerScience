import java.util.Scanner;
import java.lang.Math;
public class GCDMainClass {

	public static void main(String[] args) {
		/* Chapter 6 - CGD Program
		 * This program is intended to compute the GCD of two positive integers
		 * Any questions? Email me - christophermchong@gmail.com
		 */
		Scanner reader = new Scanner(System.in);
		//Assume user can enter positive integer
		System.out.print("Please enter the first positive integer: ");
		int n1 = reader.nextInt();
		System.out.print("Please enter the second positive integer: ");
		int n2 = reader.nextInt();
		
		int largerNumber = Math.max(n1, n2);
		int smallerNumber = Math.min(n1, n2);
		int remainder = 1;
		while (remainder != 0)
		{
			remainder = largerNumber % smallerNumber;
			largerNumber = smallerNumber;
			smallerNumber = remainder;
			
			if (smallerNumber == 0)
			{
			System.out.println("The GCF is " + largerNumber);
			}
		}
	}

}
