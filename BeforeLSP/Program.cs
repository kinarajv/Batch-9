
class Animal 
{
	public int Age { get; set; }
	public string Name { get; set; }
	public void MakeSound() 
	{
		Console.WriteLine("Grrrr");
	}
}
class Dog : Animal 
{
	public void MakeSound() 
	{
		Console.WriteLine("Bark!");
	}
}
class Program 
{
	static void Main() 
	{
		Dog dog = new Dog();
		dog.MakeSound(); // Bark!
		Animal animal = dog;
		animal.MakeSound(); // Grrrr

		IShape shape = new Sphere();
		shape.Area();
	}
}
interface IShape 
{
	public int Width { get; set; }
	public int Height { get; set; }
	public int Area();
}
class Sphere : IShape 
{
	public int Width { get; set; }
	public int Height { get; set; }
	public int Radius { get; set; }
	public int Area() 
	{
		return (int)(4 * Math.PI * Math.Pow(Radius, 2));
	}
}