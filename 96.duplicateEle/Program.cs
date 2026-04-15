using System;

class Program
{
    static void Main()
    {
        int [] array ={2,4,3,4,5,5};

        Console.WriteLine("Duplicate elements:");

        for (int i = 0 ; i < array.Length; i++)
        {
            for ( int j = i+1 ; j < array.Length ; j++)
            {
                if ( array[i] == array[j])
                {
                    Console.Write(array[j]+" ");
                    break;
                }
            }
        }
    }
}