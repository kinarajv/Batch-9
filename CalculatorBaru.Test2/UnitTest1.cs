using System.Runtime.InteropServices;

namespace CalculatorBaru.Test;

public class CalculatorTests
{
	private Calculator calculator;
	public CalculatorTests()
	{
		calculator = new Calculator();
	}

	[Fact]
	public void Add_ReturnCorrectNumber()
	{
		//3A
		//Arrange
		int a = 1;
		int b = 2;
		int expected = 3;

		//Action
		int result = calculator.Add(a, b);

		//Assert
		//Old model
		Assert.Equal(expected, result);
	}
	
	[Theory]
	[InlineData(1, 2, 3)]
	[InlineData(2, 2, 4)]
	[InlineData(2, 6, 8)]
	[InlineData(2, -1, 1)]
	public void Add_ReturnCorrectResults_UsingTestCase(int a, int b, int expected)
	{
		//3A
		//Arrange

		//Action
		int result = calculator.Add(a, b);

		//Assert
		//Old model
		Assert.Equal(expected, result);
		//Assert.Throws<Exception>(() => );
	}
}