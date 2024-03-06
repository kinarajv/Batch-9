using System.Diagnostics;

class Program {
    static void Main() {
        ConsoleTraceListener consoleTraceListener = new();
        TextWriterTraceListener textWriterTraceListener = new("trace.log");
        //Debug.Assert(false, "This is a debug assertion");
        Trace.Listeners.Add(consoleTraceListener);
        Trace.Listeners.Add(textWriterTraceListener);
        Trace.WriteLine("Starting the program");
        Add(1, 2);
        Subtract(1, 2);
    }
    static int Add(int a, int b) {
        int result = a + b;
        Trace.WriteLine("Adding" + a + " numbers" + b + " : "+ result);
        return result;
    }
    static int Subtract(int a, int b) {
        Trace.WriteLine("Subtracting" + a + " numbers" + b + " : "+ (a - b));
        return a - b;
    }
}