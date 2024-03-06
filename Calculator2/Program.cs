class Program {
    static void Main() {
        int a = 10;
        int b = 20;
        Calculator calc = new Calculator();
        int result = calc.Add(a, b);
        System.Console.WriteLine(result);
    }
}
class Calculator {
    public int Add(int a, int b) {
        return a * b;
    }
}