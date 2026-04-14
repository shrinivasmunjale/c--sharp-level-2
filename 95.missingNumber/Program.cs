using System;

class Program
{
    static void Main()
    {
        int [] arr = {1,2,4,5};
        int n = 5;

        int sum = n * (n+1)/2;

        int actualsum = 0;

        for(int i = 0; i < arr.Length ; i++)
        {
            actualsum += arr[i]; 
        }

        int missnum = sum - actualsum;

        Console.WriteLine("missing number is: "+missnum);
    }
}