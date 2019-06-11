import javax.swing.*;
import java.awt.*;
public class FranceFlag {
	// This program will make a French flag
    // By Ethan Lawrence 10/3/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JFrame theGUI = new JFrame();
		theGUI.setTitle("France Flag");
		theGUI.setSize(300, 200);
		theGUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		JPanel panel = new JPanel();
		panel.setBackground(Color.red);
		JPanel panel2 = new JPanel();
		panel2.setBackground(Color.white);
		JPanel panel3 = new JPanel();
		panel3.setBackground(Color.blue);
		Container pane = theGUI.getContentPane();
		pane.setLayout(new GridLayout(1,1,1, 1));
		pane.add(panel);
		pane.add(panel2);
		pane.add(panel3);
		theGUI.setVisible(true);
	}

}
