using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the string: ");
        String str = Console.ReadLine();
        String Temp="";

        foreach(char ch in str)
        {
            if(ch ==' ')
            {
                continue;
            }
            else
            {
                Temp += ch; 
            }
        }
        Console.Write(Temp);
    }
}