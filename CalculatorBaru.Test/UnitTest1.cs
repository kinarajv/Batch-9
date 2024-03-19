namespace CalculatorBaru.Test;

public class CalculatorTests
{
	private Calculator calculator;
	[SetUp]
	public void Setup()
	{
		calculator = new Calculator();
	}

	[Test]
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
		Assert.AreEqual(expected, result);
		//Constraint Model
		Assert.That(result, Is.EqualTo(expected));
	}
	
	[TestCase(1, 2, 3)]
	[TestCase(2, 2, 4)]
	[TestCase(2, 6, 8)]
	[TestCase(2, -1, 1)]
	public void Add_ReturnCorrectResults_UsingTestCase(int a, int b, int expected)
	{
		//3A
		//Arrange

		//Action
		int result = calculator.Add(a, b);

		//Assert
		//Old model
		Assert.AreEqual(expected, result);
		//Assert.Throws<Exception>(() => );
		//Constraint Model
		Assert.That(result, Is.EqualTo(expected));
	}
}