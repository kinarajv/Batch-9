using log4net;
using log4net.Config;
using log4net.Core;
using log4net.Repository.Hierarchy;

class Program 
{
	public static ILog Logger = LogManager
	.GetLogger(typeof(Program));
	
	static void Main() 
	{
		XmlConfigurator.Configure(new FileInfo("./log4net.config"));
		Logger.Debug("Starting robot");
		Robot robot = new();
		Logger.Info("Starting walk");
		robot.Walk();
		Logger.Info("Program end");
	}
}
class Robot 
{
	public static ILog Logger = LogManager
	.GetLogger(typeof(Robot));
	public void Walk() 
	{
		//Process Walking
		LeftLegMove();
		RightLegMove();
		Logger.Info("Already move Left and Right Leg");
	}
	void LeftLegMove() 
	{
		//Process Left Leg Move
		Logger.Info("Left Leg Move");
	}
	void RightLegMove() 
	{
		//Process Right Leg Move
		Logger.Info("Left Leg Move");
	}
}