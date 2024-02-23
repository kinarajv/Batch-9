void Main()
{
	Car car = new();
	car.Price[0].Dump();
	car.Price[0] = 6000;
	car.Price[0].Dump();
	int[] myArray = {2,3,4,5};
	//car.Price = myArray;
}
class Car {
	public readonly int[] Price = {1,2,3,4};
}
