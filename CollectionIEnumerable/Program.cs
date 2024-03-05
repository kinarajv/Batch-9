using System.Threading.Tasks;
class Program 
{
	static async Task Main() 
	{
		List<int> list = new List<int> { 1, 2, 3, 4, 5 };
		IEnumerable<int> enumerable = list;
		IEnumerator<int> enumerator = enumerable.GetEnumerator();
		while (enumerator.MoveNext()) 
		{
			Console.WriteLine(enumerator.Current);

			await Task.Delay(3000).ConfigureAwait(true);
		}
	}
}