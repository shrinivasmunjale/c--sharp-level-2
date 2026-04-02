using System ; 

class Program
{
    static void Main()
    {
        int [] Arr = {23,43,23,54};

        Console.WriteLine("Elements in arrary:");

        for (int i = 0 ; i<Arr.Length ; i++)
        {
            Console.Write(" " +Arr[i]);
        }
    }
}