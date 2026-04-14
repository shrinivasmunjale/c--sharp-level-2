using System;

class Program
{
    static void Main()
    {
        int [] arr1 = {1,3,2,5,4};
        int [] arr2 = {3,2,6,1};

        Console.WriteLine("Common elements:");

        for(int i = 0 ; i< arr1.Length ; i++)
        {
            for(int j =0 ; j<arr2.Length ; j++)
            {
                if(arr1[i] == arr2[j])
                {
                    
                    Console.Write(arr1[i] + " ");
                    break; // avoid duplicate printing
                }
            }
        }
    }
}