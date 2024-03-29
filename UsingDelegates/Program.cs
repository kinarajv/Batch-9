﻿public delegate void MyDelegate();
class Program {
	static void Main() {
		Subscriber subscriber = new();
		Database database = new();
	   	SMS sms = new();
		Email email = new();
		
		Publisher pub = new();
		pub.mySubscriber = subscriber.ReceiveNotification;
		pub.mySubscriber += database.ReceiveNotification;
		pub.mySubscriber += sms.ReceiveNotification;
		pub.mySubscriber += email.ReceiveNotification;
		pub.mySubscriber += database.ReceiveNotification;
		pub.Upload();
	}
}

class Publisher {
	public MyDelegate mySubscriber;
	public void Upload() {
		Console.WriteLine("Uploading...");
		Console.WriteLine("Finish...");
		Console.WriteLine("Inform to subscribers");
		Notify();
	}
	public void Notify() {
		mySubscriber?.Invoke();
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