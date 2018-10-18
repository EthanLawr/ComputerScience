import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;

public class CenterPoint {
	// This program will make a center point on a GUI Window
    // By Ethan Lawrence 10/18/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        JFrame theGUI = new JFrame();
        theGUI.setTitle("Center Point");
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
    	int x = getWidth(), y = getHeight();
    	Font font = new Font("Arial", Font.CENTER_BASELINE, 12);
    	g.setFont(font);
    	g.drawString("(" + x/2 + "," + y/2 + ")", x/2, y/2);
    }
}