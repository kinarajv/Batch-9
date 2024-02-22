using System.Numerics;

class Calculator {
	public static T Add<T>(T data1, T data2) where T : IAdditionOperators<T,T,T>
	{
		return data1 + data2;
	}
}
class Program {
	static void Main() {
		Human human = Calculator.Add(new Human(2),new Human(3));
		Console.WriteLine(human.age);

		Human a = new Human(2);
		Human b = new Human(3);
		Human result = a + b;
	}
}
class Human : IAdditionOperators<Human, Human, Human>
{
	public int age = 0;
	public Human(int age) 
	{
		this.age = age;
	}
	//Operator Overloading
	public static Human operator +(Human left, Human right)
	{
		return new Human(left.age + right.age);
	}
}