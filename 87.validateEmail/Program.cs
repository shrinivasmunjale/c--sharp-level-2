using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the Email : ");
        string email = Console.ReadLine();

        if(email.Contains("@") && email.Contains("."))
        {
            Console.WriteLine("Valid Email");

        }
        else
        {
            Console.WriteLine("Invalid Email");
        }
    }
}