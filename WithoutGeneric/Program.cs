//Problem
class MyCollectionOfInt {
	private int[] myArray;
	private int index = 0;
	public MyCollectionOfInt(int count) {
		myArray = new int[count];
	}
	public bool AddElement(int data) {
		if(index == myArray.Length-1) {
			return false;
		}
		myArray[index] = data;
		index++;
		return true;
	}
	public int GetElement() {
		return myArray[index];
	}
}
class MyCollectionOfString {
	private string[] myArray;
	private int index = 0;
	public MyCollectionOfString(int count) {
		myArray = new string[count];
	}
	public bool AddElement(string data) {
		if(index == myArray.Length-1) {
			return false;
		}
		myArray[index] = data;
		index++;
		return true;
	}
	public string GetElement() {
		return myArray[index];
	}
}
class MyCollectionOfCar {
	private Car[] myArray;
	private int index = 0;
	public MyCollectionOfCar(int count) {
		myArray = new Car[count];
	}
	public bool AddElement(Car data) {
		if(index == myArray.Length-1) {
			return false;
		}
		myArray[index] = data;
		index++;
		return true;
	}
	public Car GetElement() {
		return myArray[index];
	}
}
class Car {}