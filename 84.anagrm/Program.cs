using System;

class Program
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        // Convert to lowercase for case-insensitive comparison
        str1 = str1.ToLower();
        str2 = str2.ToLower();

        // Convert strings to char arrays
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        // Sort both arrays
        Array.Sort(arr1);
        Array.Sort(arr2);

        // Compare sorted arrays
        if (new string(arr1) == new string(arr2))
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are NOT Anagrams");
    }
}