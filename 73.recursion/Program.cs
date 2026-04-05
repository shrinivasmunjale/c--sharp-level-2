using System;

class Program
{
    static int fact(int n)
    {
        if(n == 0 || n == 1)
        {
            return 1;
        }

        return n* fact(n-1);
    }

    static void Main()
    {
        Console.Write("Enter the factorial number: ");

        int num = Convert.ToInt32( Console.ReadLine());

        int result = fact(num);

        Console.WriteLine($"factiorial of {num} is {result}");
    }
}