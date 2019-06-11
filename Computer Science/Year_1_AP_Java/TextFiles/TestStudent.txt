public class TestStudent {
	public static String studentName, studentSSN, studentMotherMaidenName, studentHomeAddress, studentEmail, 
	    studentPhoneNumber;
	public static double studentGPA;
	public static int studentDressSize,studentBirthday, studentGradYear;
	
	// Accessors
	public String GetStudentName() {
		return studentName;
	}
	public int GetStudentBirthday() {
		return studentBirthday;
	}
	public String GetStudentSSN() {
		return studentSSN;
	}
	public String GetStudentMotherMaidenName() {
		return studentMotherMaidenName;
	}
	public String GetStudentHomeAddress() {
		return studentHomeAddress;
	}
	public String GetStudentEmail() {
		return studentEmail;
	}
	public String GetStudentPhoneNumber() {
		return studentPhoneNumber;
	}
	public double GetStudentGPA() {
	    return studentGPA;
	}
	public int GetStudentDressSize() {
	    return studentDressSize;
	}
	public int GetStudentGradYear() {
	    return studentGradYear;
	}
	public TestStudent(){
		studentName = "John Deer";
		studentBirthday = 2001;
		studentSSN = "111-11-1111";
		studentMotherMaidenName = "Deer";
		studentHomeAddress = "123 Bob Builder's Street PA 18966";
		studentEmail = "elawrence152@gmail.com";
		studentPhoneNumber = "215-730-4920";
		studentGPA = 4.0;
		studentDressSize = 40;
		studentGradYear = 2019;
	}
	
	public TestStudent(String SomeStudentName){
		TestStudent.studentName = SomeStudentName;
	}
	
	public TestStudent(String SomeName, int SomeBirthday, String SomeSSN, String SomeMaidenName, String SomeHomeAddress,
			String SomeEmail, String SomePhoneNumber, double SomeGPA, int SomeDressSize, int SomeGradYear){
		TestStudent.studentName = SomeName;
		TestStudent.studentBirthday = SomeBirthday;
		TestStudent.studentSSN = SomeSSN;
		TestStudent.studentMotherMaidenName = SomeMaidenName;
		TestStudent.studentHomeAddress = SomeHomeAddress;
		TestStudent.studentEmail = SomeEmail;
		TestStudent.studentPhoneNumber = SomePhoneNumber;
		TestStudent.studentGPA = SomeGPA;
		TestStudent.studentDressSize = SomeDressSize;
		TestStudent.studentGradYear = SomeGradYear;
	}
}
