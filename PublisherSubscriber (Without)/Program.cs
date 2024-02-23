class Program {
	static void Main() {
		Subscriber sub = new();
		Database sub2 = new();
	   	SMS sub3 = new();
		Email sub4 = new();
		
		Publisher pub = new();
		
		pub.Upload();
	}
}

class Publisher {
	public INotification[] subs;
	public void Upload() {
		Console.WriteLine("Uploading...");
		Console.WriteLine("Finish...");
		Console.WriteLine("Inform to subscribers");
		Notify();
	}
	public void Notify() {
		foreach(var i in subs) 
		{
			i.ReceiveNotification();
		}
	}
}
public interface INotification 
{
	void ReceiveNotification();
}
class Email : INotification {
	public void ReceiveNotification() {
		"Email got notified".Dump();
	}
}
class SMS : INotification {
	public void ReceiveNotification() {
		"SMS got notified".Dump();
	}
}
class Database : INotification {
	public void ReceiveNotification() {
		"Database got notified".Dump();
	}
}
class Subscriber : INotification {
	public void ReceiveNotification() {
		"Subscriber got notified".Dump();
	}
}
class Logger 
{
	public void GotNotification() 
	{
		"Logger got notified".Dump();
	}
}
class LoggerNotification : INotification {
	public Logger logger;
	public void ReceiveNotification() 
	{
		logger.GotNotification();
	}
}
public static class Extensions 
{
	public static void Dump(this object a) 
	{
		Console.WriteLine(a);
	}
}