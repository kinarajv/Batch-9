using System.Runtime.InteropServices;

//dotnet run
//default define is DEBUG
class Program {
    static void Main() {
        #if DEBUG
            System.Console.WriteLine("DEBUG");
        #endif
        #if RELEASE 
            System.Console.WriteLine("RELEASE");
        #endif
        #if DEVELOPMENT 
            System.Console.WriteLine("DEVELOPMENT");
        #endif
    }
}