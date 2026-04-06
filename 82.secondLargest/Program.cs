using System ;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void DispayArray(int [] arr)
    {
      int largest = int.MinValue;
      int second = int.MinValue;

      foreach(int num in arr)
        {
            if(num > largest)
            {
                second = largest;
                largest = num;
            }
            else if (num > second && num != largest)
            {
                second = num;
            }
        }
             if (second == int.MinValue)
            Console.WriteLine("No second largest element found.");
        else
            Console.WriteLine("Second Largest Element: " + second);
    }
    static void Main()
    {
        int [] numbers = {3,13,32,29,20,21,73};

        DispayArray(numbers);
    }
}