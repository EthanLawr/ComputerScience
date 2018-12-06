import java.text.ParseException;
import java.util.Random;

import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class Student {
	// This program will compare 4 students.
    // By Ethan Lawrence 11/30/2018
	// elawrence152@gmail.com
	public static void main(String[] args) throws ParseException {
		JFrame frame = new JFrame();
		String oldest = "Invalid years given", highestGPA = "lol", coolest = "har";
		Random coolCalc = new Random();
		int coolFactor = coolCalc.nextInt(5);
		
		System.out.println("This program will compare 4 students.");

		
		// Defining each student
		TestStudent studentTest = new TestStudent(OptionPaneInput("Please enter a first and last name."), 
				OptionPaneInputInt("Please enter a birthday.\nExample: 2001"), 
				OptionPaneInput("Please enter social security number."), OptionPaneInput("Please enter a mother's maiden name."), 
				OptionPaneInput("Please enter a home address."), OptionPaneInput("Please enter an email."), 
				OptionPaneInput("Please enter a phone number."), OptionPaneInputDouble("Please enter a GPA."), 
				OptionPaneInputInt("Please enter a dress size."), OptionPaneInputInt("Please enter your graduation year."));


	
		TestStudent studentTestTwo = new TestStudent(OptionPaneInput("Please enter a first and last name."), 
				OptionPaneInputInt("Please enter a birthday.\nExample: 2001"), 
				OptionPaneInput("Please enter social security number."), OptionPaneInput("Please enter a mother's maiden name."), 
				OptionPaneInput("Please enter a home address."), OptionPaneInput("Please enter an email."), 
				OptionPaneInput("Please enter a phone number."), OptionPaneInputDouble("Please enter a GPA."), 
				OptionPaneInputInt("Please enter a dress size."), OptionPaneInputInt("Please enter your graduation year."));
		
		TestStudent studentTestThree = new TestStudent(OptionPaneInput("Please enter a first and last name."), 
				OptionPaneInputInt("Please enter a birthday.\nExample: 2001"), 
				OptionPaneInput("Please enter social security number."), OptionPaneInput("Please enter a mother's maiden name."), 
				OptionPaneInput("Please enter a home address."), OptionPaneInput("Please enter an email."), 
				OptionPaneInput("Please enter a phone number."), OptionPaneInputDouble("Please enter a GPA."), 
				OptionPaneInputInt("Please enter a dress size."), OptionPaneInputInt("Please enter your graduation year."));
		
		TestStudent studentTestFour = new TestStudent(OptionPaneInput("Please enter a first and last name."), 
				OptionPaneInputInt("Please enter a birthday.\nExample: 2001"), 
				OptionPaneInput("Please enter social security number."), OptionPaneInput("Please enter a mother's maiden name."), 
				OptionPaneInput("Please enter a home address."), OptionPaneInput("Please enter an email."), 
				OptionPaneInput("Please enter a phone number."), OptionPaneInputDouble("Please enter a GPA."), 
				OptionPaneInputInt("Please enter a dress size."), OptionPaneInputInt("Please enter your graduation year."));
		
		// Finding who is the oldest
		if (studentTest.GetStudentBirthday() > studentTestTwo.GetStudentBirthday() &&
				studentTestThree.GetStudentBirthday() > studentTestTwo.GetStudentBirthday() && 
				studentTestFour.GetStudentBirthday() > studentTestTwo.GetStudentBirthday()) {
			oldest = studentTestFour.GetStudentName() + " is the oldest";	
		} else if (studentTestTwo.GetStudentBirthday() > studentTest.GetStudentBirthday() &&
				studentTestThree.GetStudentBirthday() > studentTest.GetStudentBirthday() && 
				studentTestFour.GetStudentBirthday() > studentTest.GetStudentBirthday()) {
			oldest = studentTestFour.GetStudentName() + " is the oldest";
		} else if (studentTestTwo.GetStudentBirthday() > studentTestThree.GetStudentBirthday() &&
				studentTest.GetStudentBirthday() > studentTestThree.GetStudentBirthday() && 
				studentTestFour.GetStudentBirthday() > studentTestThree.GetStudentBirthday()) {
			oldest = studentTestFour.GetStudentName() + " is the oldest";
		} else if (studentTestTwo.GetStudentBirthday() > studentTestFour.GetStudentBirthday() &&
				studentTest.GetStudentBirthday() > studentTestFour.GetStudentBirthday() && 
				studentTestThree.GetStudentBirthday() > studentTestFour.GetStudentBirthday()) {
			oldest = studentTestFour.GetStudentName() + " is the oldest";
		} else {
			
		}
		
		// Finding who has the highest GPA
		if (studentTest.GetStudentGPA() > studentTestTwo.GetStudentGPA() && 
				studentTest.GetStudentGPA() > studentTestThree.GetStudentGPA() &&
				studentTest.GetStudentGPA() > studentTestFour.GetStudentGPA())
			highestGPA = studentTest.GetStudentName() + " has the highest GPA.";
		else if (studentTest.GetStudentGPA() < studentTestTwo.GetStudentGPA() &&
				studentTestTwo.GetStudentGPA() > studentTestThree.GetStudentGPA() &&
				studentTestTwo.GetStudentGPA() > studentTestFour.GetStudentGPA())
			highestGPA = studentTestTwo.GetStudentName() + " has the highest GPA.";
		else if (studentTest.GetStudentGPA() < studentTestThree.GetStudentGPA() &&
				studentTestTwo.GetStudentGPA() < studentTestThree.GetStudentGPA() &&
				studentTestThree.GetStudentGPA() > studentTestFour.GetStudentGPA())
			highestGPA = studentTestThree.GetStudentName() + " has the highest GPA.";
		else 
			highestGPA = studentTestFour.GetStudentName() + " has the highest GPA.";
		
		// Finding out who the coolest is
		if (coolFactor == 1)
			coolest = studentTest.GetStudentName() + " is the coolest.";
		else if (coolFactor == 2)
			coolest = studentTestTwo.GetStudentName() + " is the coolest.";
		else if (coolFactor == 3)
			coolest = studentTestThree.GetStudentName() + " is the coolest.";
		else 
			coolest = studentTestFour.GetStudentName() + " is the coolest.";
		
		JOptionPane.showMessageDialog(frame, oldest + "\n" + highestGPA + "\n" +coolest, "Student Info", 0);

	}
	
	public static String OptionPaneInput(String x) {
		String y = JOptionPane.showInputDialog(x);
		return y;
	}
	public static double OptionPaneInputDouble(String x) {
		double y = Double.parseDouble(JOptionPane.showInputDialog(x));
		return y;
	}
	public static int OptionPaneInputInt(String x) {
		int y = Integer.parseInt(JOptionPane.showInputDialog(x));
		return y;
	}
}