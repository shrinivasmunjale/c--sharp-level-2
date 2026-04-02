using System;

class Program
{
    static void Main()
    {
        int [] arr1 = {12,43,23,11};
        int [] arr2 = {32,54,34,22};
       


        int[] arr = new int[arr1.Length + arr2.Length];

for (int i = 0; i < arr1.Length; i++)
{
    arr[i] = arr1[i];
}

for (int i = 0; i < arr2.Length; i++)
{
    arr[arr1.Length + i] = arr2[i];
}

        Console.WriteLine("Array after Marge:");
        foreach(int num in arr)
        {
            Console.Write(num +" ");
        }

}
}