import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;

public class FreeRun {
	// This program will use the information I have learned so far
    // By Ethan Lawrence 10/19/2018
	// elawrence152@gmail.com
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        JFrame theGUI = new JFrame();
        theGUI.setTitle("Free Run");
        theGUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        theGUI.setSize(400, 300);
        theGUI.add(new ColorPanel());
        theGUI.setVisible(true);

	}

}
class ColorPanel extends JPanel {
	public ColorPanel() {
		setBackground(Color.black);
		setForeground(Color.magenta);
	}
    public void paintComponent(Graphics g) {
    	super.paintComponent(g);
    	Font font = new Font("Comic Sans", Font.PLAIN, 20);
    	int x = getWidth(), y = getHeight(), circle = (x+y)/10;
    	double radius = circle/2;
    	g.setFont(font);
    	g.drawString("(" + x/2 + "," + y/2 + ")", 10, 120);
    	g.drawOval(x/2 ,y/2, circle, circle );
    	g.drawString("Radius: " + radius , 10, 20);
    	g.drawString("Diameter: " + radius*2 , 10, 45);
    	g.drawString("Area: " + (double)((int)(radius*radius*3.141*1000))/1000, 10, 70);
    	g.drawString("Circumference: " + (double)((int)(radius*3.141*2*1000))/1000, 10, 95);
    	
    }
}