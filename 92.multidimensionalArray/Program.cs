using System;

class Program
{
    static void Main()
    {
        int [,] array =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

         Console.WriteLine("Elements of the 2D Array:");

         for (int i = 0 ; i< rows ; i++)
        {
            for (int j =0 ; j< cols ; j++)
            {
               Console.Write(array[i, j] + " "); 
            }
             Console.WriteLine();
        }


    }
}