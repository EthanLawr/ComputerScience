import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class GUIWindow extends JFrame {

	 public GUIWindow() {
		 JPanel dataPanel = new JPanel(new GridLayout(3,3,12,6));
		 dataPanel.add(fahrLabel);
		 dataPanel.add(celsiusLabel);
		 dataPanel.add(fahrField);
		 dataPanel.add(celsiusField);
		 
		 JPanel buttonPanel = new JPanel();
		 buttonPanel.add(fahrButton);
		 buttonPanel.add(celsiusButton);

		 Container container = getContentPane();
		 container.add(dataPanel, BorderLayout.CENTER);
		 container.add(buttonPanel, BorderLayout.SOUTH);
		 fahrButton.addActionListener(new FahrenheitListener());
		 celsiusButton.addActionListener(new CelsiusListener());

	 }
	 private static Thermometer thermo = new Thermometer();
	 private static JLabel fahrLabel = new JLabel("Degrees Fahrenheit");
	 private static JLabel celsiusLabel = new JLabel("Degrees Celsius");
	 private static JTextField fahrField = new JTextField("32.0");
	 private static JTextField celsiusField = new JTextField("0.0");
	 private static JButton fahrButton = new JButton("Convert >>>");
	 private static JButton celsiusButton = new JButton("<<< Convert");

	 
	 private class FahrenheitListener implements ActionListener{
			 public void actionPerformed(ActionEvent e) {
				 String input = fahrField.getText();
				 double fahr = Double.parseDouble(input);
				 thermo.setFahrenheit(fahr);
				 double celsius = thermo.getCelsius();
				 celsiusField.setText(" " + celsius);
			 }
	 }
	 private class CelsiusListener implements ActionListener{
		 public void actionPerformed(ActionEvent e) {
			 String input = celsiusField.getText();
			 double celsius = Double.parseDouble(input);
			 thermo.setCelsius(celsius);
			 double fahr = thermo.getFahrenheit();
			 fahrField.setText(" " + fahr);
		 }
 }
}
