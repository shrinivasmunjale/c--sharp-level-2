using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");

        sb.Append("World");

        Console.WriteLine("After Append: "+ sb);

        // Insert text
        sb.Insert(5, " C#");
        Console.WriteLine("After Insert: " + sb);

        // Replace text
        sb.Replace("C#", "Programming");
        Console.WriteLine("After Replace: " + sb);

        // Remove text
        sb.Remove(5, 12);
        Console.WriteLine("After Remove: " + sb);

        // Convert to string
        string result = sb.ToString();
        Console.WriteLine("Final String: " + result);
    }
}