class Program
{
	static void Main()
	{
		Console.WriteLine("Start Program");
		try { //Part of program will be executed
			ExceptionMaker();
		}	
		catch(FormatException e) {
			"Ada format yang gagal".Dump();
		}
		catch(IndexOutOfRangeException e) {
			"Index diluar array".Dump();
		}
		catch(Exception e) {
			"Another exception happen".Dump();
		}
		Console.WriteLine("Finish Program");
	}
	static void ExceptionMaker() {
		Console.WriteLine("Start Exception Maker Method");
		string a = Console.ReadLine();
		bool status = int.TryParse(a, out int index);
		int[] myArray = {1,2,3};
		if(index>myArray.Length-1) {
			return;
		}
		myArray[index].Dump();
		
		Console.WriteLine("Finish Exception Maker Method");
	}
}