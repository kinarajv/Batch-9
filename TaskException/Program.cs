class Program {
    static void Main() {
        try {
            Task task = Task.Run(() => ExceptionMaker());
            task.Wait();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
    static void ExceptionMaker() {
        throw new FormatException("Exception thrown from ExceptionMaker"); 
    }
}