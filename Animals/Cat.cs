namespace Animals;

public class Cat : Animal
{
	public Cat(string colour, string gender) : base(colour, gender)
	{
		Console.WriteLine("Cat (child) created");
	}
	public string name;
	public void Meow() 
	{
		Console.WriteLine("Meow");
	}
}
