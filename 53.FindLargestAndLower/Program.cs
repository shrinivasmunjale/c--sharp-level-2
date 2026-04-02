using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        int big, low;

        // Input
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter the element of array: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Display
        Console.WriteLine("Elements of array:");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }

        // Initialize
        big = arr[0];
        low = arr[0];

        // Find largest and smallest
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > big)
            {
                big = arr[i];
            }

            if (arr[i] < low)
            {
                low = arr[i];
            }
        }

        Console.WriteLine("Largest number: " + big);
        Console.WriteLine("Lowest number: " + low);
    }
}