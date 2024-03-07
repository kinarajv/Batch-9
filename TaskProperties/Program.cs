class Program {
    static void Main() {
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("+");
                Thread.Sleep(5);
            }
        });
        Console.WriteLine(task.IsCompleted);
        Console.WriteLine(task.IsCanceled);
        Console.WriteLine(task.IsFaulted);
        Task.WaitAll(task);
    }
}