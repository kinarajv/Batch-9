using System.Text.Json;
class Human 
{
	public string Name { get; set; } //Property
	public int Age { get; set; }
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
		// Human human = new Human("Kinara", 25);
		// Human human2 = new Human("Dion", 22);
		// Human human3 = new Human("Gracia", 22);
		// List<Human> humans = new List<Human> { human, human2, human3 };
		// string json = JsonSerializer.Serialize(humans);
		// using(StreamWriter sw = new("file.json")) 
		// {
		// 	sw.Write(json);
		// }

		string result;
		using(StreamReader sr = new("file.json")) 
		{
			result = sr.ReadToEnd();
		}
		Human[] humans = JsonSerializer.Deserialize<Human[]>(result);
		foreach(var human in humans) 
		{
			Console.WriteLine(human.Name);
			Console.WriteLine(human.Age);
		}
	}
}
