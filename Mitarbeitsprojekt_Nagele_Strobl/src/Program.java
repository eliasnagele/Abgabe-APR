import lejos.hardware.Audio;
import lejos.hardware.BrickFinder;
import lejos.hardware.BrickInfo;
import lejos.hardware.Button;
import lejos.hardware.Key;
import lejos.hardware.KeyListener;
import lejos.hardware.Sound;
import lejos.hardware.ev3.LocalEV3;
import lejos.hardware.lcd.GraphicsLCD;
import lejos.hardware.lcd.LCD;
import lejos.hardware.motor.EV3LargeRegulatedMotor;
import lejos.hardware.motor.EV3MediumRegulatedMotor;
import lejos.hardware.port.MotorPort;
import lejos.hardware.port.SensorPort;
import lejos.hardware.sensor.EV3GyroSensor;
import lejos.hardware.sensor.EV3UltrasonicSensor;
import lejos.robotics.RegulatedMotor;
import lejos.robotics.SampleProvider;
import lejos.utility.Delay;
import lejos.utility.Stopwatch;

import java.util.Random;
import java.util.Scanner;

public class Program {

	public static RegulatedMotor motorleft = new EV3LargeRegulatedMotor(MotorPort.B);		//create left motor
    public static RegulatedMotor motorright = new EV3LargeRegulatedMotor(MotorPort.C); 		//create right motor
    
    public static EV3UltrasonicSensor ev3us = new EV3UltrasonicSensor(SensorPort.S4);		//create distance sensor
    
    public static EV3GyroSensor gyroSensor = new EV3GyroSensor(SensorPort.S1);
    
    public static SampleProvider gyro = gyroSensor.getAngleMode();
	public static float [] gyrosample = new float[gyro.sampleSize()];
	
	public static SampleProvider sp = ev3us.getDistanceMode();
	public static double distanceValue;
	public static float [] sample = new float[sp.sampleSize()];
	
    
	
	public static void main(String[] args) {	
		display();
		
		motorleft.setSpeed(600);		
    	motorright.setSpeed(600);
		
    	drivemode1();
	}
	
	
	
	public static void display(){
		LCD.drawString("Press 'up' key ", 0, 0);
		LCD.drawString("to start!", 0, 1);
		Button.UP.waitForPress();

		LCD.clear();
		LCD.drawString("Press 'down' key", 0, 0);
		LCD.drawString("to stop!", 0, 1);
	}
	
	
	public static void drivemode1() {		//drive forward as long as there is no object within 30 centimeters; when there is an object either make a 90° or 180° turn
		sp.fetchSample(sample, 0);
		distanceValue = (double)sample[0];
		
		while(Button.DOWN.isUp()) {
			sp.fetchSample(sample, 0);
			distanceValue = (double)sample[0];		//measure the distance to the next object
			
			while(distanceValue > 0.3) {		//while distanceValue > 30 cm drive forward in a straight line
				motorleft.forward();
				motorright.forward();
				sp.fetchSample(sample, 0);
				distanceValue = (double)sample[0];
				if(Button.DOWN.isDown()) {		//if Button.DOWN is pressed set distanceValue to 0.1 so the while loop stops
					distanceValue = 0.1;
				}
			}
			
			Random random = new Random();		//generate a random number which determines if the robot makes a 90° or a 180° turn
			int upperbound = 2;
			int int_random = random.nextInt(upperbound);
			
			gyroSensor.reset();
			gyro.fetchSample(gyrosample, 0);
			
			
			if(Button.DOWN.isUp() && int_random==0) {			//if Button.DOWN isn't pressed and int_random is 0 make a 90° turn
				motorleft.setSpeed(200);
				motorright.setSpeed(200);
				
				motorleft.forward();
				motorleft.backward();
				do {
					gyro.fetchSample(gyrosample, 0);
				}while(gyrosample[0] < 75);
				motorleft.stop();
				motorright.stop();
			}
			
			else if(Button.DOWN.isUp() && int_random==1) {			//if Button.DOWN isn't pressed and int_random is 1 make a 180° turn
				motorleft.setSpeed(200);
				motorright.setSpeed(200);

				motorleft.forward();
				motorright.backward();
				do {
					gyro.fetchSample(gyrosample, 0);
				}while(gyrosample[0] < 150);
				motorleft.stop();
				motorright.stop();
			}
			
			motorleft.setSpeed(600);
			motorright.setSpeed(600);
		}
	}
}
	

