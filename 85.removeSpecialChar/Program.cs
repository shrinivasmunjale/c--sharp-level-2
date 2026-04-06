using System;

class Program
{
    static void Main()
    {
        string str1 = "shree@gmail.com";
        string result = "";

        foreach(char ch in str1)
        {
            if (char.IsLetterOrDigit(ch))
            {
                result += ch;
            }
        }

        Console.WriteLine("Original String:"+ str1);

        Console.WriteLine("After removing special Characters: "+result);

    }
}