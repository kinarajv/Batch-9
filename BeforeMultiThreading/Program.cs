class Program {
    static void Main() {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        Printer();
        Printer2();
    }
    static void Printer() {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        for(int i = 0; i < 100; i++) {
            Console.Write("+");
        }
    }
    static void Printer2() {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        for(int i = 0; i < 100; i++) {
            Console.Write("-");
        }
    }
}