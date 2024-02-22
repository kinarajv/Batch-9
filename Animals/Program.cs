using Animals;
class Program 
{
	static void Main() 
	{
		Cat cat = new Cat("yellow", "male");
		cat.colour = "yellow";
		cat.gender = "male";
		cat.name = "cinamon";
		Console.WriteLine(cat.colour);
		cat.Walk();
		cat.Breath();
		cat.Meow();

		Animal animal = cat;
		animal.Walk();
		animal.Breath();
		//Parent(Animal)  <= Child(Cat)
		//Tidak komplit <= Komplit
	}
}