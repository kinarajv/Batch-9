using System.Diagnostics;

class Program {
    static void Main() {
        int iteration = 100000;
        Stopwatch stopwatch = new();
        stopwatch.Start();
        for(int i = 0; i < iteration; i++) {
            InstanceCreator();
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
    static void InstanceCreator() {
        Human human = new Human();
    }
}   

class Human {
    ~Human() { //Destructor
    }
}