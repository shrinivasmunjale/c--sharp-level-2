using System ; 

class Program
{
    static void Main()
    {
        int [] Arr = {23,43,23,54};
        int sum =0;
        float avg;

        Console.WriteLine("Elements in arrary:");

        for (int i = 0 ; i<Arr.Length ; i++)
        {
            sum += Arr[i];
            
        }
        avg = (float)sum / Arr.Length;

        Console.WriteLine("Sun of Array Element: "+ sum);

        Console.WriteLine("Avarage of array Element is: "+avg);
    }
}