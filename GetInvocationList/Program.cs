public delegate void MyDelegate();
class Program {
	static void Main() {
		Subscriber subscriber = new();
		
		Publisher pub = new();
		pub.AddSubscriber(subscriber.ReceiveNotification);
		pub.Upload();
	}
}

class Publisher {
	private MyDelegate mySubscriber;
	public bool AddSubscriber(MyDelegate myDelegate) 
	{
		if(mySubscriber is null) 
		{
			mySubscriber += myDelegate;
			return true;
		}
		if(mySubscriber.GetInvocationList().Contains(myDelegate)) 
		{
			return false;
		}
		mySubscriber += myDelegate;
		return true;
	}
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

class Subscriber {
	public void ReceiveNotification() {
		"Subscriber got notified".Dump();
	}
}
public static class Extensions 
{
	public static void Dump(this object a) 
	{
		Console.WriteLine(a);
	}
}