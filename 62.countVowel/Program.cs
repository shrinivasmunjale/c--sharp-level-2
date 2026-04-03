using System;

class Program
{
    static void Main()
    {

        int count =0;
        Console.WriteLine("Enter the string: ");

        string str = Console.ReadLine();
        int n = str.Length;

        for( int i=0 ; i< n ; i++)
        {
            char ch = char.ToLower(str[i]);
            if(ch =='a'||ch=='e' || ch=='i'||ch=='o' ||ch=='u' )
            {
                count ++;
            }
        }

        Console.WriteLine("Total vowels in given string is : "+count);
    }
}