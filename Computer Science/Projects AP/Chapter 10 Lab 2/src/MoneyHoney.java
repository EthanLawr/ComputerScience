import java.util.ArrayList;

public class MoneyHoney {
	// Ethan Lawrence
	// This program will see how much cash is in a piggy bank
	// 3/8/2019
	// elawrence152@gmail.com
	public static void main(String[] args) {
		double amount = 0;
		ArrayList<Money> piggyBank = new ArrayList<Money>();

		System.out.print("This program sees how much is inside a piggy bank");
		
		piggyBank.add(new Quarter());
		piggyBank.add(new Bill(1));
		piggyBank.add(new Nickel());
		piggyBank.add(new Dime());
		piggyBank.add(new Quarter());
		piggyBank.add(new Bill(5));
		
		System.out.println(piggyBank);
		
		for (Money item : piggyBank) amount += item.getAmount();
		System.out.printf("The piggy bank holds $%.2f\n",  amount);
	}

}
