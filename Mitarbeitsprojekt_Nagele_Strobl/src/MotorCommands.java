import lejos.hardware.motor.EV3LargeRegulatedMotor;
import lejos.hardware.port.MotorPort;
import lejos.robotics.RegulatedMotor;
import lejos.utility.Delay;

public class MotorCommands {
	public static RegulatedMotor motorleft = new EV3LargeRegulatedMotor(MotorPort.B);
    public static RegulatedMotor motorright = new EV3LargeRegulatedMotor(MotorPort.C);
    
    public static void MoveForward(int time, int speed) {
    	motorleft.setSpeed(speed);
    	motorright.setSpeed(speed);
    	
    	motorleft.forward();
    	motorright.forward();
    	
    	Delay.msDelay(time);
    }
    
    public static void MoveBackwards(int time, int speed) {
    	motorleft.setSpeed(speed);
    	motorright.setSpeed(speed);
    	
    	motorleft.backward();
    	motorright.backward();
    	
    	Delay.msDelay(time);
    }
}
