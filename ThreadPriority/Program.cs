class Program {
    static void Main() {
        Thread t1 = new Thread(() => Console.WriteLine("Thread 1"));
        t1.Name = "Yanto";
        t1.IsBackground = true;
        t1.Priority = ThreadPriority.Highest; //Forbidden
        t1.Start();
        t1.Abort();
    }
}