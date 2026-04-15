using System;

// Reference type class
class Person
{
    public string Name;
}

class Program
{
    static void Main()
    {
        // 🔸 VALUE TYPE (int)
        int a = 10;
        int b = a;   // Copy of value

        b = 20;

        Console.WriteLine("Value Type Example:");
        Console.WriteLine("a = " + a); // 10 (unchanged)
        Console.WriteLine("b = " + b); // 20

        // 🔸 REFERENCE TYPE (class)
        Person p1 = new Person();
        p1.Name = "John";

        Person p2 = p1; // Copy of reference

        p2.Name = "Smith";

        Console.WriteLine("\nReference Type Example:");
        Console.WriteLine("p1.Name = " + p1.Name); // Smith (changed)
        Console.WriteLine("p2.Name = " + p2.Name); // Smith
    }
}