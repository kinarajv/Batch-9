using System.Runtime.InteropServices.ComTypes;
class Program {
    static async Task Main() {
        DatabaseManagement db = new();
        
        Task<string> resultOfTask = new Task<string>(db.Reader);
        resultOfTask.Start();
        resultOfTask.Wait();
        string result = resultOfTask.Result;
        Console.WriteLine(result);

        string resultOfAsync = await db.ReaderAsync();
        Console.WriteLine(resultOfAsync);
        await db.DelayerAsync();
    }
}
class DatabaseManagement {
    public string Reader() {
        //db.Categories.Add(asdasd)
        Thread.Sleep(5000);
        return "database data";
    }
    public async Task<string> ReaderAsync() {
        //db.Categories.Add(asdasd)
        await Task.Delay(5000);
        return "database data";
    }

    public async Task DelayerAsync() {
        //db.Categories.Add(asdasd)
        await Task.Delay(5000);
    }
}