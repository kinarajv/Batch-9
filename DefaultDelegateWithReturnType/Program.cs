//Method => return type = float
//Param ->  int, int
public delegate float MyDelegate(int a,int b);

class Program 
{
	static void Main() 
	{
		
		Subscriber subscriber = new();
		//Custom Delegate
		MyDelegate del = subscriber.Add;

		//public delegate T2 Func<T,T1,T2>(T data1, T1 data2)
		Func<int, int, float> action = subscriber.Add;
		Func<int, int, float> action1 = subscriber.Mul;
		

		action?.Invoke(3,4);
		action1?.Invoke(3 , 4);
	}
}
class Subscriber 
{
	public float Add(int a, int b) 
	{
		return (a + b);
	}
	public float Mul(int a, int b) 
	{
		return (a + b);
	}
}