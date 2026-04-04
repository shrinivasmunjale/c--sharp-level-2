using System;

class Program
{
    static void Main()
    {
        String str = "maharashtra";

        int [] freq = new int[256];

        foreach(char ch in str)
        {
            freq[ch]++;

        }
        Console.WriteLine("\nCharacter Frequencies:");

        for (int i = 0; i < 256; i++)
        {
            if (freq[i] > 0)
            {
                Console.WriteLine((char)i + " : " + freq[i]);
            }
    }
}
}