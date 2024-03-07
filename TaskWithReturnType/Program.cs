class Program {
    static void Main() {
        Task<int> task = new Task<int>(ReturnNine);
        task.Start();
        Console.WriteLine(task.Result);
    }
    static int ReturnNine() {
        return 9;
    }
}
