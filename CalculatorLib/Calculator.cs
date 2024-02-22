namespace CalculatorLib;
public class Calculator 
{
	public int Operation(int a, int b, CalculatorOperation operation) 
	{
		return operation.Process(a, b);
	}
}
class Addition : CalculatorOperation
{
	public int Process(int a, int b) 
	{
		return a + b;
	}
}

class Multiplication : CalculatorOperation
{
	public int Process(int a, int b) 
	{
		return a * b;
	}
}

class Division : CalculatorOperation
{
	public int Process(int a, int b) 
	{
		return a / b;
	}
}

//SOLID
// Single Responsibility
// Open Close Principle
		// Open for Extensions
		// Close for Modification/Change
