class Program {
	static void Main() {
		Employee emp = new Employee("Dion",69);
		Console.WriteLine(emp.name);
		Console.WriteLine(emp.id);
		
		emp.email = "dion@fmlx.com";
		Console.WriteLine(emp.email);
	}
}

class Employee {
	public string name;
	public string email;
	public int id;
	
	//Constructor
	public Employee(string name, int id) {
		this.name = name;
		this.id = id;
	}
}