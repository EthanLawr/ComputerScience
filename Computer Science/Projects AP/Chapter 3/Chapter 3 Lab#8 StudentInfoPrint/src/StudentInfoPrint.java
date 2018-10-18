import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;

public class StudentInfoPrint {
	// This program will make show info about a student
    // By Ethan Lawrence 10/18/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        JFrame theGUI = new JFrame();
        theGUI.setTitle("Student Info Print");
        theGUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        theGUI.setSize(400, 300);
        theGUI.add(new ColorPanel());
        theGUI.setVisible(true);

	}

}
class ColorPanel extends JPanel {
	public ColorPanel() {
		setBackground(Color.white);

	}
    public void paintComponent(Graphics g) {
    	super.paintComponent(g);
    	Font font = new Font("Comic Sans", Font.PLAIN, 20);
    	g.setFont(font);
    	g.drawString("Name: Ethan Lawrence", 10, 20);
    	g.drawString("Graduating Year: 2019", 10, 45);
    	g.drawString("Cell Phone: (267) - 751 - 9909", 10, 70);
    }
}