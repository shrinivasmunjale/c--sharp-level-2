using System;

class Program
{
    static void student(String name , int roll)
    {
        

        Console.WriteLine("Name of Student: "+name);
        Console.WriteLine("Roll number of student:"+roll);

    }
    static void student(String result)
    {
        Console.WriteLine("Result of student: "+result);
    }
    static void Main()
    {
        student("shree",13);
        student("pass");
    }
}