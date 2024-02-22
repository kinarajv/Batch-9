//Custom Properties
class Human {
	// Property
	// Variable method (PascalCase)
	private int _balance;
	//public int Balance {get;set;}
	public int Balance {
		get {
			return _balance;
		}
		set {
			_balance = value * 1000;
		}
	} 
	
	
}

class Program {
	static void Main() {
		Human human = new();
		human.Balance = 2;
		human.Balance.Dump();
	}
}
