class Program 
{
	static void Main() 
	{
		Cat cat = new Cat();
		cat.Eat(); // Cat eat
		cat.Eat("tulang"); // Cat eat tulang
	}
}

class Cat 
{
	public string colour;
	public string name;
	public string gender;
	
	public void Eat() 
	{
		Console.WriteLine("Cat eat");
	}
	public void Eat(string food) 
	{
		Console.WriteLine("Cat eat "+ food);
	}
}