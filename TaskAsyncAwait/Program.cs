class Program{
    static async void Main() {
        Task task = new Task(() => Delayer());
        await task;
    }
    static async void Delayer() {
        await Task.Delay(5000);
    }
}