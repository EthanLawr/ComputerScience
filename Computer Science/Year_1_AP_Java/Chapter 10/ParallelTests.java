import java.util.Scanner;

public class ParallelTests {
    public static void main(String args[]) {
        String[] studentNames = new String[5];
        double[][] studentGrades = {{0,0,0,0,0},{0,0,0,0,0}};
        double[] studentAverages = {0,0,0,0,0};
        double totalScore = 0;
        
        
        System.out.println("This program will get the names of 5 students, their test scores, and their averages. An example of the output will be this:");
        System.out.println("Student1\t\t\t\tStudent2\t\t\t\tStudent3\t\t\t\tStudent4\t\t\t\tStudent5" +
            "\nStudent1Score1\t\t\tStudent2Score1\t\t\tStudent3Score1\t\t\tStudent4Score1\t\t\tStudent5Score1" +
            "\nStudent1Score2\t\t\tStudent2Score2\t\t\tStudent3Score2\t\t\tStudent4Score2\t\t\tStudent5Score2" +
            "\nStudent1AverageScore\tStudent2AverageScore\tStudent3AverageScore\tStudent4AverageScore\tStudent5AverageScore" +
            "\nClassAverageScore\n");
        // Getting Students names
        for (int i = 0; i < studentNames.length; i++) {
            System.out.println("Please enter a student's name");
            studentNames[i] = userInputMethodString();
        }
        

        // Getting Students Grades
        for (int row = 0; row < studentGrades.length; row++) {
            for (int col = 0; col < studentGrades[row].length; col++) {
                studentGrades[row][col] = userInputMethodDouble(row, studentNames[col]);
                studentAverages[col] += studentGrades[row][col];
            }
        }
        
        // Displays names
        for (String i : studentNames) {
            // Formatting
            if (i.length() <= 3) System.out.print(i + "\t\t");
            else System.out.print(i + "\t");
        }
        
        // Displays grades
        for (int row = 0; row < studentGrades.length; row++) {
            System.out.println();
            for (int col = 0; col < studentGrades[row].length; col++) System.out.print(studentGrades[row][col] + "\t");
        }
        
        System.out.println();
        for (double i : studentAverages) {
            totalScore += i;
            System.out.print(i/2.00 + "\t");
        }
        
        System.out.println("\nThe average score of the class on both tests is: " + totalScore / 10);
        
        System.out.println();

    }
    
    // Methods for a Nasty Gram in a user input
    public static String userInputMethodString() {
        try {
            Scanner userInput = new Scanner(System.in);
            String name = userInput.nextLine();
            if (name.length() > 5) {
                System.out.println("Please enter a shortened version of this name.");
                userInputMethodString();
            }

            return name;
        } catch (Exception e) {
            System.out.print("Please enter a valid student name. ");
            return userInputMethodString();
        }
    }
    
    public static double userInputMethodDouble(int x, String y) {
        if (x == 0) System.out.print("Please enter a chapter 6 score for the student known as " + y + ": ");
        if (x == 1) System.out.print("Please enter a chapter 9 score for the student known as " + y + ": ");
        try {
            Scanner userInput = new Scanner(System.in);
            double number = userInput.nextDouble();
            // Nastygram to make sure the user inputs a valid number
            if (number > 100 || number < 0) {
                System.out.println("Please enter a valid number between 0 and 100 for the test score.");
                number = userInputMethodDouble(x , y);
            }

            return number;
        } catch (Exception e) {
            System.out.print("Please enter a valid test score. ");
            return userInputMethodDouble(x, y);
        }
    }
}
