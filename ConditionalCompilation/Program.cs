
class Program {
    static void Main() {
        #if WINDOWS
            System.Console.WriteLine("Windows");
        #else 
            System.Console.WriteLine("Linux");
        #endif
    }
}