using Overriding;

class Program 
{
	static void Main() 
	{
		// Animal animal = new();
		// //animal.Sound();

		// Cat cat = new();
		// //cat.Sound();

		// //Animal animal2 = new Ant();
		// //animal2.Sound();

		// Console.WriteLine("-----");

		MakeSound(new Ant());
		Ant ant = new Ant();
		ant.Sound();
	}
	static void MakeSound(Animal animal) 
	{
		animal.Sound();
	}
}