using System;

class Program
{
    static void Main()
    {
        string name = "Shri";
        int age = 20;
        double marks = 85.6789;

        // 1. Composite Formatting
        Console.WriteLine("Name: {0}, Age: {1}, Marks: {2}", name, age, marks);

        // 2. String Interpolation
        Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}");

        // 3. Format Specifiers
        Console.WriteLine("Marks (2 decimal): {0:F2}", marks);

        // 4. Alignment
        Console.WriteLine("Left Align: |{0,-10}|", name);
        Console.WriteLine("Right Align: |{0,10}|", name);

        // 5. Currency and Date Formatting
        double salary = 25000;
        DateTime today = DateTime.Now;

        Console.WriteLine("Salary: {0:C}", salary);
        Console.WriteLine("Date: {0:dd/MM/yyyy}", today);
    }
}