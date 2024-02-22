void Main()
{
	Calculator calc = new();
	int a = 3;
	int b = 2;
	int result = (int) calc.Add(3,2);
}

class Calculator {
	public object Add(object obj1, object obj2) {
		if(obj1 is int a && obj2 is int b) {
			return a+b;
		}
		if(obj1 is string c && obj2 is string d) {
			return c + d;
		}
		return null;
	}
}