class Program {
	static void Main() {
		Human human = new Human(200);
		Human human2 = new Human(300);
		Human human3 = new Human(400);
		Human.GetCount().Dump();
		human.GetBalance().Dump();
	}
}
class Human {
	private static int count;
	private int _balance;
	public Human(int money) {
		count++;
		_balance = money;
	}
	//Static method
	public static int GetCount() { 
		return count;
	}
	//Non static method
	public int GetBalance() {
		return _balance;
	}
}