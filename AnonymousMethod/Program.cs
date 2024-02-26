//Method => return type = float
//Param ->  int, int

//Anonymous Method (Lambda Expression)
class Program 
{
	static void Main() 
	{
		//Anonymous Method
		//Simple Process
		Func<int, int, float> myFunc = (int a, int b) => 
		{ 
			if(a > 0) 
			{
				return a + b;
			}
			return a + b;
		};
		myFunc += (int a, int b) => a * b;
		float a = myFunc.Invoke(3, 4);
		Console.WriteLine(a);

		Action<string> notification = (string a) => Console.WriteLine(a);

		Action notification2 = () => Console.WriteLine("invoked");
	}
}
	// public float Add(int a, int b) 
	// {
	// 	return (a + b);
	// }
	class Human 
	{
	private int _balance;
	public int Balance => _balance * 100;
	}