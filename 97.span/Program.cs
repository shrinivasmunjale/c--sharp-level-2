using System;

class Program
{
    static void Main()
    {
        int [] array = {34,2,45,3,22};

        Span<int> span = array;

        Console.Write ("Original Array: ");
        foreach(int i in array)
        {
            Console.Write(i +" ");
        }


        span[1] = 99;
        span[2] = 32;

        Console.WriteLine("\n\n Modified Array using Span:");

        foreach( int n in array)
        {
            Console.Write(n +" ");
        }

         // Create ReadOnlySpan
        ReadOnlySpan<int> readOnlySpan = Array;

          Console.WriteLine("ReadOnlySpan Elements:");

        foreach (var n in readOnlySpan)
            Console.Write(n + " ");

          //  This will give compile-time error:
        // readOnlySpan[1] = 100;   
    }
}