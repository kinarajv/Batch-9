//Generic
//Flexibility of Class/Method

class Program {
	static void Main() {
		var myCollection = new MyCollection<int,string>(20);
		myCollection.AddElement(2,"two");
		myCollection.AddElement(4,"four");
		Data<int,string> mytuple = myCollection.GetElement();
		mytuple.data.Dump();
		mytuple.data2.Dump();
		
	}
}
class MyCollection<T,T2>{
	private T[] myArray;
	private T2[] myArray2;
	private int index = 0;
	public MyCollection(int count) {
		myArray = new T[count];
		myArray2 = new T2[count];
	}
	public bool AddElement(T data, T2 data2) {
		if(index == myArray.Length-1) {
			return false;
		}
		myArray[index] = data;
		myArray2[index] = data2;
		index++;
		return true;
	}
	public Data<T,T2> GetElement() {
		return new Data<T,T2>(myArray[index-1],myArray2[index-1]);
	}
}
class Data<T,T2> {
	public T data;
	public T2 data2;
	public Data(T data, T2 data2) {
		this.data = data;
		this.data2 = data2;
	}
}