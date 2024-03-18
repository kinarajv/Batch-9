class Program
{
	static void Main() 
	{
		List<int> list = new List<int> { 1, 2, 3, 4, 5 };
		list.Hitung();
	}
}
public static class Extension 
{
	public static void Hitung(this List<int> list) 
	{
		int total = 0;
		foreach(int i in list) 
		{
			total += i;
		}
		Console.WriteLine(total);
	}
}