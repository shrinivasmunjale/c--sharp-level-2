using System;

class student
{
    private string[] names = new string[5];

    public string this[int index]
    {
        get
        {
            if (index>=0 && index < names.Length)
            {
                return names[index];
            }
        else{
            return "Invali Index";
        }
        }
        set
        {
            if (index >= 0 && index < names.Length)
                names[index] = value;
        }
    }



}

class Program
{
    static void Main()
    {
        student st = new student();

        st[0] = "Rahul ";
        st[1] = "Amit";
        st[2] = "shree";

        // Getting values using indexer
        Console.WriteLine("Student Names:");
        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
        Console.WriteLine(s[2]);

        // Invalid index
        Console.WriteLine(s[10]);
    }
}