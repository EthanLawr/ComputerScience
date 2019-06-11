import javax.swing.*;
//brings in JFrame and JPanel
import java.awt.*;
//brings in color and container
public class GUIWindow {
	// This program will use GUI with java
    // By Ethan Lawrence 10/3/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JFrame theGUI = new JFrame();
		theGUI.setTitle("My First GUI Program");
		theGUI.setSize(300, 200);
		theGUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		JPanel panel = new JPanel();
		panel.setBackground(Color.pink);
		Container pane = theGUI.getContentPane();
		pane.add(panel);
		theGUI.setVisible(true);
		
	}

}