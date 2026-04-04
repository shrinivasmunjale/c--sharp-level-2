using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        // Using Equals method
        if (str1.Equals(str2))
        {
            Console.WriteLine("Strings are equal (case-sensitive)");
        }
        else
        {
            Console.WriteLine("Strings are not equal (case-sensitive)");
        }

        // Using Compare method
        int result = string.Compare(str1, str2);

        if (result == 0)
            Console.WriteLine("Strings are equal");
        else if (result < 0)
            Console.WriteLine("First string is smaller");
        else
            Console.WriteLine("First string is greater");
    }
}