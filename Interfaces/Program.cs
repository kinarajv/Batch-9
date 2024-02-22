
public interface IBluetooth {
	void Connect();
	void Disconnect();
}
public interface IWireless {
	void Connect();
	void Disconnect();
}
public class Device : IBluetooth, IWireless
{
	void IBluetooth.Connect()
	{
		Console.WriteLine("IBluetooth Connect");
	}

	void IBluetooth.Disconnect()
	{
		 Console.WriteLine("IBluetooth Disconnect");
	}
	void IWireless.Connect()
	{
		Console.WriteLine("IWireless Connect");
	}

	void IWireless.Disconnect()
	{
		 Console.WriteLine("IWireless Disconnect");
	}
}

class Program 
{
	static void Main() 
	{
		Device device = new();
		IBluetooth bluetooth = device;
		bluetooth.Connect();

		IWireless wireless = device;
		wireless.Connect();
		
		
	}
}