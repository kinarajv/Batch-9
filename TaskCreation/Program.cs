class Program {
    static void Main() {
        Task t1 = new Task(() => Console.WriteLine("Task 1"));
        t1.Start();
        t1.Wait();
        Task.Run(() => Console.WriteLine("Task 2"));
    }
}