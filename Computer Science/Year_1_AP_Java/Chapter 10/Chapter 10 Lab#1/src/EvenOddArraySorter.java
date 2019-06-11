import java.util.*;

public class EvenOddArraySorter
{
	/* Ethan Lawrence
	 * 2/4/2019
	 * This program will sort even and odd numbers */
    public static void main(String[] args) 
    { 
        Scanner userInput = new Scanner(System.in);
        int[] evenarr = new int[10], oddarr = new int[10], negativearr = new int[10];
        
        System.out.println("This program will sort negative, even, and odd numbers.");
        System.out.print("Please enter 10 numbers to sort");
        for (int i = 0; i < evenarr.length; i++) { 
        	evenarr[i]=userInput.nextInt();
        }
        for (int i = 0; i < 10; i++) oddarr[i] = evenarr[i];
        for (int i = 0; i < 10; i++) negativearr[i] = evenarr[i];
        
  	    for (int i = 0; i < 10; i++) if (evenarr[i] % 2 == 1 || evenarr[i] - 1 == 0 || evenarr[i] + 1 == 0) evenarr[i] = 0;
        for (int i = 0; i < 10; i++) if (evenarr[i] != 0) System.out.print(evenarr[i] + " "); 
        System.out.println();
        
        findEvens(oddarr);
        for (int i = 0; i < 10; i++) if (oddarr[i] != 0) System.out.print(oddarr[i] + " ");  
        System.out.println();
        
        for (int i = 0; i < 10; i++) if (negativearr[i] >= 0) negativearr[i] = 0; 
        for (int i = 0; i < 10; i++) if (negativearr[i] != 0) System.out.print(negativearr[i] + " ");  
        userInput.close();
    } 
    
    public static void findEvens(int[] oddarr) {
    	  for (int i = 0; i < oddarr.length; i++) {
    		  if (oddarr[i] % 2 == 0) oddarr[i] = 0;
    		  }
    	  return;
    }
 
}
