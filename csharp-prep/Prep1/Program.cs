using System;

class Program
{
    static void Main(string[] args)
    {
        // link to assignment instructions
        // https://byui-cse.github.io/cse210-course-2023/unit01/csharp-1.html

        Console.WriteLine("What is your first name? ");
        string fname = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}