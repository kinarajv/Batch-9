namespace Overriding;

public class Animal
{
	public string gender;
	public string colour;
	public string name;
	public void Walk()
	{
		Console.WriteLine("Walk");
	}
	public virtual void Sound() 
	{
		Console.WriteLine("Animal Make Sound");
	}
}
public class Cat : Animal
{
	public override void Sound()
	{
		Console.WriteLine("Meow");
	}
}
public class Dog : Animal
{
	public override void Sound()
	{
		Console.WriteLine("Bark");
	}
}
public class Ant : Animal
{
	public new void Sound() 
	{
		Console.WriteLine("zzzzz");
	}
}