class Program {
    static void Main() {
        string input = "3a";
        try {
            int[] myIntegers = { 1, 2, 3 };
            Console.WriteLine(myIntegers[4]);
            int result = int.Parse(input);
            Console.WriteLine(result);
        }
        catch(FormatException e) {
            Console.WriteLine("Format Exception handled");
        }
        finally { //Exception/No exception, finally will executed
            Console.WriteLine("Program closed");
        }
    }
}