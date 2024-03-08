class Program {
    public static object obj = new object();
    static int Counter = 0;
    static async Task Main() 
    {
        Console.WriteLine("Main method started");
        Task task1 = Task.Run(async () => await Incrementer());
        Task task2 = Task.Run(async () => await Incrementer());
        await Task.WhenAll(task1, task2);
        Console.WriteLine("Main method completed");
    }
    static async Task Incrementer() {
        for(int i = 0; i < 100; i++) {
            lock(obj) 
            {
                Counter++;
                Console.WriteLine(Counter);
            }
            await Task.Delay(50);
        }
    }
}