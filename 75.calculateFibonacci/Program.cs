using System;

class Program
{
    static int fobinacci (int a)
    {
        if(a == 0)
        {
            return 0;
        }
        if(a == 1)
        {
            return 1;
        }

        return fobinacci(a-1) + fobinacci(a - 2);

    }
    static void Main()
    {
        int sum =0;


        
        Console.Write("Enter the Ending point:");
        int end = Convert.ToInt32(Console.ReadLine());

       for(int i = 0 ; i < end; i++)
        {
            Console.Write(fobinacci(i)+" ");

            sum += fobinacci(i);
        }

        Console.WriteLine("\n Sum of series is : "+sum);


    }
}