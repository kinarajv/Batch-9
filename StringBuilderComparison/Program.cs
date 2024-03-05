using System.Text;
using System.Diagnostics;

class Program {
    static void Main() {
        StringBuilder myString = new();
        int iteration = 100_000_000;
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < iteration; i++) {
            myString.Append("a");
            myString.Append("b");
            myString.Append("c");
            Thread.Sleep(50);
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
        Console.ReadLine();
    }
}