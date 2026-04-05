using System;

class Program
{
    // Method with optional parameters
    static void Display(string name, int age , string city )
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
        Console.WriteLine();
    }

    static void Main()
    {
        // Passing all arguments
        Display(name:"Rahul",age: 22, city:"Mumbai");

       
        Display(  age : 43, name:"shree", city:"latur");

        Display("Sneha", 25 , "pune");
    }
}