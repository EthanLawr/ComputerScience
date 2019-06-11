import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;

public class HelloGUIWorld {
	// This program will make text in a GUI window
    // By Ethan Lawrence 10/17/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        JFrame theGUI = new JFrame();
        theGUI.setTitle("Hello GUI World Program");
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
    	g.drawRoundRect(10, 10, 200, 200, 30, 30);
    	Font font = new Font("Arial", Font.PLAIN, 12);
    	g.setFont(font);
    	g.drawString("Hello GUI World!", 30, 30);
    }
}