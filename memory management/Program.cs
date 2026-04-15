using System;

class Demo
{
    public int value;

    public Demo(int v)
    {
        value = v;
        Console.WriteLine("Object created with value: " + value);
    }

    ~Demo() // Destructor (called by Garbage Collector)
    {
        Console.WriteLine("Object destroyed (Garbage Collected)");
    }
}

class Program
{
    static void Main()
    {
        // 🔸 VALUE TYPE (Stored in Stack)
        int a = 10;
        Console.WriteLine("Value type (Stack): " + a);

        // 🔸 REFERENCE TYPE (Stored in Heap)
        Demo obj1 = new Demo(100);
        Demo obj2 = new Demo(200);

        // Remove reference
        obj1 = null;

        Console.WriteLine("Forcing Garbage Collection...");

        // Force Garbage Collection
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("End of Program");
    }
}