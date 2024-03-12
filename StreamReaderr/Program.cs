class Program 
{
	static async Task Main() 
	{
		using(FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate))
		{
			using(StreamWriter sr = new StreamWriter(fs))
			{
				sr.AutoFlush = true;
				fs.Seek(0, SeekOrigin.End);
				sr.WriteLine("Hello, World!");
				fs.Seek(-7, SeekOrigin.End);
				sr.WriteLine("Hello, World!");
				sr.WriteLine("Hello, World!");
			}
		}
		using(FileStream fs = new FileStream("test.txt", FileMode.Open))
		{
			using(StreamReader sr = new StreamReader("test.txt"))
			{
				string result = await sr.ReadToEndAsync();
				Console.WriteLine(result);
			}
		}
	}
}