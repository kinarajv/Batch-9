class Program {
    static void Main() {

        //Thread is foreground by default
        Console.WriteLine("Program started");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        Task task1 = new Task(Printer); // Printer1
        Task task2 = Task.Run(() => Printer2()); // Printer2
     
        task1.Start();
        task2.Start();
        Task[] tasks = {task1, task2};
        Task.WaitAll(task1, task2);
        Console.WriteLine("Program finished");
    }
    static void Printer() {
        Console.WriteLine("Printer 1");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("+");
        // }
    }
    static void Printer2() {
        Console.WriteLine("Printer2");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("-");
        // }
    }
    static void Printer3() {
        Console.WriteLine("Printer3");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("/");
        // }
    }
    static void Printer4() {
        Console.WriteLine("Printer4");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("?");
        // }
    }
}