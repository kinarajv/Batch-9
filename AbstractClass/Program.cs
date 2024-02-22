class Program {
	static void Main() {
		Animal animal = new Cat();
	}
}

abstract class Animal { //Base class
	public string name;
	public string gender;
	//non abstract
	public void Walk() {
		"Walk".Dump();
	}
	//abstract <> override
	public abstract void Sound();
}
class CatParents {}
class Cat : Animal {
	public override void Sound() {
		"Meow".Dump();
	}
}
public static class Extension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x);
	}
}