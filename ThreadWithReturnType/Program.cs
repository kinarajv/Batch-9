class Program {
    static void Main() {
        int result = 0;
        Thread t1 = new Thread(() => result = ReturnNine());
        t1.Start();
        t1.Join();
        Console.WriteLine(result);
    }
    static int ReturnNine() {
        return 9;
    }
}
