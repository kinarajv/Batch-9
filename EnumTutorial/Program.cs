//Enum
public enum Days {
	Monday = 3,
	Tuesday = 3,
	Wednesday = 4,
	Thursday,
	Friday = 2,
	Saturday = 2,
	Sunday = 2
}
class Program {
	static void Main() {
		MondayCheck(Days.Monday);
		Days.Monday.Dump();
		int result = (int)Days.Sunday;
		result.Dump();
		
		int check = 2;
		Days dayToCheck = (Days)check;
		dayToCheck.Dump();
	}
	static void MondayCheck(Days day) {
		if(day == Days.Monday) {
			"true".Dump();
		}
	}
}