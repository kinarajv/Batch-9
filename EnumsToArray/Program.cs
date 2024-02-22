//Status Code
// 404 = NotFound
// 300 = Redirect
// 401 = Unauthorized
// 500 = Internal Server Error
// 200 = OK
public enum StatusCode : int {
	NotFound = 404,
	Redirect = 300,
	Unauthorized = 401,
	InternalServerError = 500,
	OK = 200
}
class Program {
	static void Main() {
		short x = 404;
		StatusCode code = (StatusCode)x;
		Console.WriteLine(code);
		// Array result = Enum.GetValues(typeof(StatusCode));
		// foreach(object? i in result) 
		// {
		// 	Console.WriteLine(i);
		// }
	}
}