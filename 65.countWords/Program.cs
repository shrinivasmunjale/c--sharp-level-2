using System;

class Program
{
    static void Main()
    {

        int count = 1;
        
        Console.WriteLine("Enter the string: ");

        string str = Console.ReadLine();
        int n = str.Length;

        for( int i= 0 ; i< n-1 ; i++)
        {
           
        if (str[i]== ' ' && str[i + 1]!=' ')
        {
            
            count ++;
        }
        
        }
        if(count == 1)
        {
            Console.WriteLine("Total words is string is 1 "); 
        }

        Console.WriteLine("Total words is string is "+ count);


    }
}