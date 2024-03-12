class Program 
{
	static async Task Main() {
		using (FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate)) {
			using (StreamWriter sw = new StreamWriter(fs)) {
				sw.AutoFlush = true;
				fs.Seek(0, SeekOrigin.End);
				await sw.WriteLineAsync("Hello, World!");
				await sw.FlushAsync();
				fs.Seek(-7, SeekOrigin.End);
				await sw.WriteLineAsync("Hello, World!");
				await sw.FlushAsync();
				await sw.WriteLineAsync("Hello, World!");	
				await sw.FlushAsync();
			}
		}
	}
}