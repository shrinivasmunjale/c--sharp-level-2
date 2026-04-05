using System;

class Program
{
    static void Addnumber(int a , int b)
    {
        int sum = a + b;

        Console.WriteLine("Addition of two number: "+sum);

    }
    static void Main()
    {
        Addnumber(5,7);
        Addnumber(90,45);
    }
}