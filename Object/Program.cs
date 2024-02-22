class Program
{
	static void Main()
	{
		int a = 3;
		object obj = a; //Boxing

		int result = (int)obj; //Unboxing
	}
	static object Add(int a, int b)
	{
		return "hello";
	}

}