using System.Text.Json;
using System.Xml.Serialization;
//Public Property & Public Variable
//Need parameterless Constructor
public class Human 
{
	public string Name { get; set; } //Property
	public int Age; //Variable
	public Human() 
	{
	}
	public Human(string name, int age) 
	{
		Name = name;
		Age = age;
	}
}
class Program 
{
	static void Main() 
	{
		// Human kinara = new Human("Kinara", 25);
		// Human dion = new Human("Dion", 22);
		// Human gracia = new Human("Gracia", 22);
		// Human[] humans = new Human[] { kinara, dion, gracia };
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(Human[]));
		// using(StreamWriter sw = new("file.xml")) 
		// {
		// 	xmlSerializer.Serialize(sw, humans);
		// }
		Human[] result;
		using(StreamReader sr = new("file.xml")) 
		{
			result = (Human[])xmlSerializer.Deserialize(sr);
		}
		foreach(var human in result) 
		{
			Console.WriteLine(human.Name);
			Console.WriteLine(human.Age);
		}
	}
}