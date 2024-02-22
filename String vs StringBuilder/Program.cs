using System.Diagnostics;
using System.Text;
class Program 
{
	static void Main() 
	{
		Stopwatch sw = new();
		int iteration = 1000;
		string result = "";
		sw.Start();
		for(int i = 0; i < iteration; i++) 
		{
			result += "a";
			result += "b";
			result.Replace("a", "c");
		}
		sw.Stop();
		Console.WriteLine("String = " + sw.ElapsedMilliseconds);

		StringBuilder sb = new();
		sw.Restart();
		for(int i = 0; i < iteration; i++) 
		{
			sb.Append("a");
			sb.Append("b");
			sb.Replace("a", "c");
		}
		sw.Stop();
		Console.WriteLine("StringBuilder = " + sw.ElapsedMilliseconds);

	}
}