using System;

class Program
{
    // Method with optional parameters
    static void Display(string name, int age = 18, string city = "Pune")
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
        Console.WriteLine();
    }

    static void Main()
    {
        // Passing all arguments
        Display("Rahul", 22, "Mumbai");

        // Skipping optional parameters
        Display("Amit");

        // Passing only some optional parameters
        Display("Sneha", 25);
    }
}