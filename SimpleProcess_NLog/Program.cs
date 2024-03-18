
using NLog;

class Program 
{
	public static Logger logger = LogManager.GetCurrentClassLogger();
	static void Main() 
	{
		logger.Debug("Starting robot");
		Robot robot = new();
		logger.Info("Starting walk");
		robot.Walk();
		logger.Info("Program end");
	}
}
class Robot 
{
	public static Logger logger = LogManager.GetCurrentClassLogger();
	public void Walk() 
	{
		//Process Walking
		LeftLegMove();
		RightLegMove();
		logger.Info("Already move Left and Right Leg");
	}
	void LeftLegMove() 
	{
		//Process Left Leg Move
		logger.Info("Left Leg Move");
	}
	void RightLegMove() 
	{
		//Process Right Leg Move
		logger.Info("Left Leg Move");
	}
}