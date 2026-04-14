using System ;

class Program
{
    static void Main()
    {
        int [][] array = new int [3][];


        array[0] = new int[] {3,5,4};
        array[1] = new int [] {1,3};
        array[2] = new int [] {3,6,54,5};

        Console.WriteLine("jugged Array Elements:");

        for (int i= 0 ; i < array.Length ; i++)
        {
            Console.Write("row "+i + ":");

            for (int j = 0 ; j < array[i].Length; j++)
            {
                Console.Write(array[i][j]+ " ");
            }
            Console.WriteLine();
        }
    }
}