import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.Color;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;


public class GUIWindow extends JFrame {

	 private static Thermometer thermo = new Thermometer();
	 private static JLabel fahrLabel = new JLabel("Degrees Fahrenheit");
	 private static JLabel celsiusLabel = new JLabel("Degrees Celsius");
	 private static JTextField fahrField = new JTextField("32.00");
	 private static JTextField celsiusField = new JTextField("0.00");
	 private static JButton fahrButton = new JButton("Convert >>>");
	 private static JButton celsiusButton = new JButton("<<< Convert");
	 
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
	 
	 private class FahrenheitListener implements ActionListener{
			 public void actionPerformed(ActionEvent e) {
				 try {
					 celsiusField.setForeground(Color.BLACK);
					 fahrField.setForeground(Color.BLACK);
					 String input = fahrField.getText();
					 double fahr = Double.parseDouble(input);
					 thermo.setFahrenheit(fahr);
					 double celsius = thermo.getCelsius();
					 String formattedCelsius = String.format("%.2f", celsius); 
					 celsiusField.setText(" " + formattedCelsius);
					 String formattedFahr = String.format("%.2f", fahr); 
					 celsiusField.setForeground(Color.BLUE);
					 fahrField.setText(" " + formattedFahr);
					 if (celsius < -273) {
						 celsiusField.setText("Invalid Number!");
						 celsiusField.setForeground(Color.RED);
					 }
				 } catch(Exception f) {
					 celsiusField.setText("Invalid Number!");
					 celsiusField.setForeground(Color.RED);
				 }
				 
			 }
	 }
	 private class CelsiusListener implements ActionListener{
		 public void actionPerformed(ActionEvent e) {
			 try {
				 celsiusField.setForeground(Color.BLACK);
				 fahrField.setForeground(Color.BLACK);
				 String input = celsiusField.getText();
				 double celsius = Double.parseDouble(input);
				 thermo.setCelsius(celsius);
				 double fahr = thermo.getFahrenheit();
				 String formattedCelsius = String.format("%.2f", celsius); 
				 celsiusField.setText(" " + formattedCelsius);
				 String formattedFahr = String.format("%.2f", fahr); 
				 fahrField.setText(" " + formattedFahr);
				 fahrField.setForeground(Color.BLUE);
				 if (celsius < -273) {
					 fahrField.setText("Invalid Number!");
					 fahrField.setForeground(Color.RED);
				 }
			 } catch(Exception f) {
				 fahrField.setText("Invalid Number!");
				 fahrField.setForeground(Color.RED);
			 }
		 }
	 }
}
