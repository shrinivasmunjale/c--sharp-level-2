using System ;
using System.ComponentModel.DataAnnotations;

class Program
{
       static void Main()
    {
        String str = "my name is shree";

        string [] worlds = str.Split(" ");

        foreach(string world in worlds)
        {
            Console.WriteLine(world);
        }
    }
}