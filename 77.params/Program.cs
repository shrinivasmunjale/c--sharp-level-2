using System;

class Program
{

    static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach(int num in numbers)
        {
            sum+= num;
        }
        return sum ;
    }
    static void Main()
    {
         Console.WriteLine("Sum of 2 numbers: " + Add(10, 20));
        Console.WriteLine("Sum of 3 numbers: " + Add(10, 20, 30));
        Console.WriteLine("Sum of 5 numbers: " + Add(1, 2, 3, 4, 5));

    }
}