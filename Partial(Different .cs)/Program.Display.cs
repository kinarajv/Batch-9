namespace MainProgram;

public partial class Program
{
	static void Display(string message) 
	{
		Console.WriteLine(message);
	}
	static string GetInput() 
	{
		string input = Console.ReadLine();
		if(!String.IsNullOrEmpty(input)) 
		{
			return input;
		}
		return "none";
	}
}
