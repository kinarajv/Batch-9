class Program 
{
	static void Main() //Method
	{
		Cat cinamon = new Cat();
		cinamon.colour = "orange";
		cinamon.gender = "male";
		cinamon.name = "cinamon";
		cinamon.isAlive = true;
		Console.WriteLine(cinamon.name);
		Console.WriteLine(cinamon.colour);
		Console.WriteLine(cinamon.gender);
		cinamon.Walk();

		Cat moca = new Cat();
		moca.colour = "black";
		moca.gender = "male";
		moca.name = "moca";
		moca.isAlive = true;
		Console.WriteLine(moca.name);
		Console.WriteLine(moca.colour);
		Console.WriteLine(moca.gender);
		moca.Walk();
	}
}
class Cat //Blueprint
{ //curly bracket
	public string name;
	public string colour;
	public string gender;
	public int length;
	public bool isAlive;
	public void Run() 
	{
		Console.WriteLine("Run");
	}
	public void Walk() 
	{
		Console.WriteLine("Walk");
	}
	public void Meow() 
	{
		Console.WriteLine("Meow");
	}
	
	public void Sleep() 
	{
		Console.WriteLine("Sleep");
	}
}