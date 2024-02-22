//Overloading
//Method/Constructor with same name, but different parameter
class Program {
	static void Main() {
		Employee emp = new Employee("Dion",69);
		Console.WriteLine(emp.name);
		Console.WriteLine(emp.id);
		Employee emp2 = new Employee("Dion",69,"dion@fmlx.com");
		Console.WriteLine(emp.email);
	}
}

class Employee {
	public string name;
	public string email;
	public int id;

	//Constructor (name , id)
	public Employee(string name, int id) {
		this.name = name;
		this.id = id;
	}
	//Constructor (name, id, email)
	public Employee(string name, int id, string email) {
		this.name = name;
		this.id = id;
		this.email = email;
	}
	
	//Add additional constructor
	//Parameterless Constructor
	public Employee() 
	{
		id = 0;
		name = "default";
		email = "default@fmlx.com";
	}
}