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


        
        Console.Write("Enter the Ending point:");
        int end = Convert.ToInt32(Console.ReadLine());

       for(int i = 0 ; i < end; i++)
        {
            Console.Write(fobinacci(i)+" ");
        }


    }
}