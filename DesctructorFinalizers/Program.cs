class Program
{
    static void Main()
    {
        InstanceCreator();
        GC.Collect(); //Halt/Freeze
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }
    static void InstanceCreator()
    {
        Human human = new Human();
    }
}
class Human {
    public Human() { //Constructor
        Console.WriteLine("Human created");
        Console.WriteLine(GC.GetGeneration(this));
    }
    ~Human() { //Destructor
        Console.WriteLine("Human destroyed");
        Console.WriteLine(GC.GetGeneration(this));
    }
}