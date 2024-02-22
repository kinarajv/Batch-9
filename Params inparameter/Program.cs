void Main()
{
	int result = Calculator.Add(3,4,5);
	result.Dump();
}

public static class Calculator 
{
	public static int Add(params int[] numbers) {
		int result = 0;
		for(int i = 0; i < numbers.Length; i++) {
			result += numbers[i];
		}
		//foreach(var i in numbers) {
		//	result += i;
		//}
		return result;
	}
}

public static class Extension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x);
	}
}