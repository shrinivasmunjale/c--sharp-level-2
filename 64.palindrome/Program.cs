using System;

class Program
{
    static void Main()
    {

        int count =0;
        string reverse ="";
        Console.WriteLine("Enter the string: ");

        string str = Console.ReadLine();
        int n = str.Length;

        for( int i=n-1 ; i>=0 ; i--)
        {
            char ch = str[i];
             reverse += ch;
        }

        if (str == reverse)
        {
            
        Console.WriteLine("Given String is palindrom");
        }
        else
        {
             Console.WriteLine("Given String is not a palindrom");
        }

    }
}