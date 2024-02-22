//Generic Constraint
//To limit the flexibility of Generic
// where T : .....
using System.Numerics;
class Program {
	static void Main() {
		var calc = new Calculator<int>();
		int result = calc.Add(3,4);
		result.Dump();
	}
}
class Calculator {}
class Calculator<T,T2>:Calculator 
	where T : INumber<T>
	where T2 : INumber<T2>
	{
	public T Add(T data1, T data2) {
		return data1 + data2;
	}
}
	