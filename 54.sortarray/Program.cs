using System;

class Program
{
    static void Main()
    {
        int [] arr = {12,43,23,11};
        int temp;


        for (int i=0 ; i< arr.Length - 1 ; i++)
        {
            for(int j= 0 ; j < arr.Length-i-1; j ++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
            
        }
        Console.WriteLine("Sorted array: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}