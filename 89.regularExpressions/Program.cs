using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
     string text = "My email is test123@gmail.com and my number is 9876543210";
    
     string emailpattern = @"\w+@\w.\w+";
     Match email = Regex.Match(text,emailpattern);

     Console.WriteLine("Email Found: "+ email.Value);

     string phonepattern = @"\d{10}";
     Match phone = Regex.Match(text,phonepattern);

     Console.WriteLine("Phone number: "+phone);

       // 3. Check if string contains only digits
        string input = "12345";
        if (Regex.IsMatch(input, @"^\d+$"))
        {
            Console.WriteLine("Input contains only digits");
        }

        // 4. Replace digits with *
        string replaced = Regex.Replace(text, @"\d", "*");
        Console.WriteLine("After replacing digits: " + replaced);
    }
}