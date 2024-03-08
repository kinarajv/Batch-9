class Program {
    static async Task Main() {
        Console.WriteLine("Main method started");

        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        Task task1 = Task.Run(() => DoPrintJob(token));
        Task.Run(() => UserInputCheck(cts));
        try
        {
            await task1;
        } catch(TaskCanceledException) {
            Console.WriteLine("Print Job Cancelled");
        }
        Console.WriteLine("Main method completed");
    }
    static async Task DoPrintJob(CancellationToken token) {
     // Print 1 - 100%
        for(int i = 0; i < 100; i++) {
            Console.WriteLine(i + "%");
            await Task.Delay(100 , token);
            // if(token.IsCancellationRequested) {
            //     Console.WriteLine("Print Job Cancelled");
            //     return;
            // }
        }
        Console.WriteLine("Print Job Completed");
    }

    static void UserInputCheck(CancellationTokenSource cts) {
        // Check for user input
        if(Console.ReadKey().KeyChar == ' ') {
            // Cancel the print job") {
            cts.Cancel();
        }
    } 
}