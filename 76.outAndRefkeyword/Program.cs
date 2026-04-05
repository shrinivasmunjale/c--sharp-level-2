using System;

class Program
{
    static void increment(ref int n)
    {
        
        n = n+10;
    }

    static void getvalues(out int a, out int b)
    {
        a = 100;
        b = 132;
    }
    static void Main()
    {
        int n =10;

        Console.WriteLine("value without using the ref keyworld:"+n);

        increment(ref n);
        Console.WriteLine("After ref: " + n);

        // out example
        int x, y;
        getvalues(out x, out y);
        Console.WriteLine("Out values: " + x + ", " + y);


    }
}