using System.Diagnostics.Contracts;

namespace Animals;

public class Animal
{
	public string colour;
	public string gender;
	public Animal(string colour, string gender) 
	{
		this.colour = colour;
		this.gender = gender;
	}
	public void Walk() 
	{
		Console.WriteLine("Animals walk");
	}
	public void Breath() 
	{
		Console.WriteLine("Animal Breath");
	}
}
