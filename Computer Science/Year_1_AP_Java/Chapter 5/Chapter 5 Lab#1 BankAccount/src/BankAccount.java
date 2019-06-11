import java.util.Scanner;

public class BankAccount {
	// This program will use a class to get a bank account.
    // By Ethan Lawrence 11/30/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		Scanner userInput = new Scanner(System.in);
		
		System.out.println("This program will use a class to get a bank account.");
		System.out.println("Please enter your name. Press enter. Then enter your social security number. Press enter." +
		    "Lastly type in your initial balance.");
		BankingInfo bankAccount = new BankingInfo(userInput.nextLine(), userInput.nextLine(), userInput.nextDouble());
		
		BankingInfo.ChangeInitialBalance();
		
		System.out.println("Your name is: " + bankAccount.GetOwnerName());
		System.out.println("Your social security number is: " + bankAccount.GetOwnerSSN());
		System.out.println("Your balance is now: " + bankAccount.GetBalance());
	}

}

class BankingInfo {
	public static String ownerName, ownerSSN;
	public static double Balance;
	
	// Accessors
	public String GetOwnerName() {
       return ownerName;
	}
	public String GetOwnerSSN() {
	       return ownerSSN;
	}
	public double GetBalance() {
	       return Balance;
	}
	
	
	public BankingInfo(){
		ownerName = "John Deer";
		ownerSSN = "11-111-1111";
		Balance = 0;
	}
	
	public BankingInfo(String SomeOwnerName, String SomeOwnerSSN, double SomeBalance){
		BankingInfo.ownerName = SomeOwnerName;
		BankingInfo.ownerSSN = SomeOwnerSSN;
		BankingInfo.Balance = SomeBalance;
	}
	
	public static void ChangeInitialBalance() {
		Scanner userInput = new Scanner(System.in);
		System.out.println("Please enter a 1 to withdraw and a 2 to deposit. If you wish to do neither type any other integer." +
		 "\n Please keep in mind your balance is currently: $" + BankingInfo.Balance);
		int changer = userInput.nextInt();
		if (changer == 1) {
			System.out.print("Please enter an amount to withdraw: ");
			double withdraw = userInput.nextDouble();
			while (withdraw > BankingInfo.Balance || withdraw <= 0) {
				System.out.print("Please enter a valid amount to withdraw: ");
				withdraw = userInput.nextDouble();
			}
			BankingInfo.Balance -= withdraw;
			ChangeInitialBalance();
		} else if (changer == 2) {
			System.out.print("Please enter an amount to deposit: ");
			double deposit = userInput.nextDouble();
			while (deposit <= 0) {
				System.out.print("Please enter a valid amount to deposit: ");
				deposit = userInput.nextDouble();
			}
			BankingInfo.Balance += deposit;
			ChangeInitialBalance();
		} else {
			// Do Nothing
		}
	}
}
