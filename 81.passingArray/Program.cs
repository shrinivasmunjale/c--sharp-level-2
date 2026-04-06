using System ;

class Program
{
    static void DispayArray(int [] arr)
    {
      Console.WriteLine("Array elements are: ");  

      foreach(int num in arr)
        {
            Console.Write(num +" ");
        }
    }
    static void Main()
    {
        int [] numbers = {3,13,32,29,20,21,73};

        DispayArray(numbers);
    }
}