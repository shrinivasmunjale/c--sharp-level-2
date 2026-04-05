using System;

class Program
{
    // Static method
    static void Greet()
    {
        Console.WriteLine("Hello, welcome to C# programming!");
    }

    // Static method with return value
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        // Calling static methods directly (no object needed)
        Greet();

        int result = Add(10, 20);
        Console.WriteLine("Sum: " + result);
    }
}