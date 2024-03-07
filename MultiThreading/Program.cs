class Program {
    static void Main() {

        //Thread is foreground by default
        Console.WriteLine("Program started");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        Thread thread1 = new Thread(Printer); // Printer1
        Thread thread2 = new Thread(Printer2); // Printer2
        Thread thread3 = new Thread(Printer3); // Printer3
        Thread thread4 = new Thread(Printer4); // Printer4
     
        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();
        // // Wait for the threads to finish
        // thread1.Join();
        // thread2.Join();
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