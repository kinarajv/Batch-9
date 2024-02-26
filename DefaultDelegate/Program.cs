//Method => return type = void
//Param ->  string
public delegate void MyDelegate(string s);

class Program 
{
	static void Main() 
	{
		
		Subscriber subscriber = new();
		//Custom Delegate
		MyDelegate del = subscriber.Notification;

		//public delegate void Action<T>(T parameter)
		Action<string> action = subscriber.Notification;
		//public delegate void Action<T,T1>(T param1, T1 param2);
		Action<int, int> action1 = subscriber.Add;

        Action<string> mydelegate = subscriber.Notification;
        Action<int, int> mydelegate2 = subscriber.Add;

		action?.Invoke("message");
		action1?.Invoke(3 , 4);
	}
}
class Subscriber 
{
	public void Notification(string data) 
	{
		Console.WriteLine(data);
	}
	public void Add(int a, int b) 
	{
		Console.WriteLine(a + b);
	}
}