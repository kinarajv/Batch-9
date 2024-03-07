class Program {
    static void Main() {

        //Thread is foreground by default
        Console.WriteLine("Program started");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        Thread thread1 = new Thread(()=> Printer("hello")); // Printer1
        thread1.Start();
        Thread thread2 = new Thread(Wrapper);
        thread2.Start();
        Console.WriteLine("Program finished");
    }
    static void Wrapper() {
        Printer("hello");
    }
    static void Printer(string message) {
        Console.WriteLine(message);
    }
    

}