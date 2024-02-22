class Human {
	// Property
	// Variable method (PascalCase)
	public int Balance {get; private set;} 
	
	public void SetBalance(int balance) {
		Balance = balance;
	}
	
	//Variable (camelCase)
	private int balance; 
	public int GetBalance() {
		return balance;
	}
	private void Setbalance(int balance) {
		this.balance = balance;
	}
}

class Program {
	static void Main() {
		Human human = new();
		human.Balance.Dump();
		human.SetBalance(2000);
		human.Balance.Dump();
	}
}
