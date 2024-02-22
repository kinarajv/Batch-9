class Program 
{
	static void Main() 
	{
		Calculator calculatormurah = new Calculator();
		int result = calculatormurah.Addition(2,3);
		Console.WriteLine("Hasil penjumlahan adalah " + calculatormurah);
		Console.WriteLine($"Hasil penjumlahan adalah {result}");
	}
}
class Calculator //PascalCase //class KucingOren
{
	public int Addition(int angka1, int angka2) //PascalCase //LompatJauh
	{
		return angka1 + angka2;
	}
}

class KucingAnggora 
{
	public string  name; //camelCase
	public bool isAlive; //camelCase
	public void LompatJauh() 
	{
		
	}
}