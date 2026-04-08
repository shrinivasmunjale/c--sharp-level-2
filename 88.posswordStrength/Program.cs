using System;
using System.Reflection.PortableExecutable;

class Program
{

    static bool isStrongPassword(string pass)
    {
        bool hasupper = false;
        bool haslower = false;
        bool hasdigit = false;
        bool hasspecial = false;

        if(pass.Length < 8)
        {
            return false;
        }

        foreach(char ch in pass)
        {
            if (char.IsUpper(ch))
            {
                hasupper = true;
            }
            else if (Char.IsDigit(ch))
            {
                hasdigit = true;
            }
             else if (Char.IsLower(ch))
            {
                haslower = true;
            }
            else
            {
                hasspecial = true;
            }
        }
            return hasupper && haslower && hasdigit && hasspecial;
    }
    static void Main()
    {
        Console.Write("Enter the Password : ");
        string password = Console.ReadLine();

        if (isStrongPassword(password))
        {
            Console.WriteLine("password is strong");
        }
        else
        {
            Console.WriteLine("Password is week..");
        }
    }
}