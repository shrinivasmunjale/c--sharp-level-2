using System;

class Program
{
    static void Main()
    {
        string st = "hello from C#";

        string upper = st.ToUpper();

        string lower = st.ToLower();

        Console.WriteLine("After uppercase : "+ upper);
        Console.WriteLine("After lover case : "+ lower);
    }
}