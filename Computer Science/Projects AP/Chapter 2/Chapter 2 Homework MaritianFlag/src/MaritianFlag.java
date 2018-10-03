import javax.swing.*;
import java.awt.*;
public class MaritianFlag {
	// This program will make a Maritian flag
    // By Ethan Lawrence 10/3/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JFrame theGUI = new JFrame();
		theGUI.setTitle("Maritian Flag");
		theGUI.setSize(300, 200);
		theGUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		JPanel panel = new JPanel();
		panel.setBackground(Color.red);
		JPanel panel2 = new JPanel();
		panel2.setBackground(Color.green);
		JPanel panel3 = new JPanel();
		panel3.setBackground(Color.yellow);
		JPanel panel4 = new JPanel();
		panel4.setBackground(Color.green);
		Container pane = theGUI.getContentPane();
		pane.setLayout(new GridLayout(4,1,1,1));
		pane.add(panel);
		pane.add(panel2);
		pane.add(panel3);
		pane.add(panel4);
		theGUI.setVisible(true);
	}

}
