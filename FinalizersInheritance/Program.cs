using System.Diagnostics;

class GrandParent {
    ~GrandParent() {
        System.Console.WriteLine("GrandParent's finalizer");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
class Parent : GrandParent {
    ~Parent() {
        System.Console.WriteLine("Parent's finalizer");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
class Child : Parent {
    ~Child() {
        System.Console.WriteLine("Child's finalizer");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
class Program {
    static void Main() {
        InstanceCreator();
        GC.Collect(); //Halt/Freeze
        GC.WaitForPendingFinalizers();
        System.Console.WriteLine("Press any key to exit");
        System.Console.ReadLine();
    }
    static void InstanceCreator() {
        Child child = new Child();
    }
}