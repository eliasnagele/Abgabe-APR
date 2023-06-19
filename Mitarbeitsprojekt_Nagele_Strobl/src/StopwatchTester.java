import lejos.hardware.Button;
import lejos.hardware.lcd.LCD;
import lejos.utility.Stopwatch;

public class StopwatchTester {
	private Stopwatch timer = new Stopwatch();
	 
	 void startMeasuring() {
		 int time;
		 timer.reset();
		 LCD.drawString("Timer started", 0, 1);
		 
		 Button.ENTER.waitForPress();
		 time = timer.elapsed();
		 LCD.drawString("Timer stopped", 0, 2);
		 
		 LCD.drawString("", 0, 3);
		 LCD.drawString("Time passed:", 0, 4);
		 LCD.drawString(time + " milliseconds", 0, 5);
		 
		 LCD.drawString((time / 1000.0) + " seconds", 0,
				 6);
	 }
}
