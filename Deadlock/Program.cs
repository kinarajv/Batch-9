class Program
{
    static async Task Main()
    {
        Console.WriteLine("Program started");
        Task task1 = null;
        Task task2 = null;
        task2 = Task.Run(async () =>
        {
            Console.WriteLine("Task2 started");
            Console.WriteLine("Task2 completed");
        });
        await task2;
        task1 = Task.Run(async () =>
        {
            Console.WriteLine("Task1 started");
            await task2;
            Console.WriteLine("Task1 completed");
        });
        await task1;
        Console.WriteLine("Program finished");
    }
}