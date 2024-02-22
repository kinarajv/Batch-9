//Composition
using Kitchen;
using Vehicle;
class Program 
{
	static void Main() 
	{
		Vehicle.Engine engine = new(8, 400, 500, "rotary");
		Tire tire = new Tire("toyo", 17);
		Car car = new Car(engine, "yellow", "toyota", 4, tire);
		Tire tire2 = new("yokohama", 17);
		car.tire = tire2;

		Cake cake = new();
	}
}
