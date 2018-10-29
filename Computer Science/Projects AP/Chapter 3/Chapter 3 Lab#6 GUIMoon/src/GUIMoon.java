import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;

public class GUIMoon {
	// This program will make a moon in a GUI Window
    // By Ethan Lawrence 10/18/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        JFrame theGUI = new JFrame();
        theGUI.setTitle("GUI Moon Program");
        theGUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        theGUI.setSize(300, 300);
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
    	g.setColor(Color.black);
    	g.drawArc(10, 10, 150, 150, 285, -210);
    	g.drawArc(44, 10, 150, 150, 258, -156);
    }
}
