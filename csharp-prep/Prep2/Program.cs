using System;

class Program
{
    static void Main(string[] args)
    {

        // assignment instructions
        // https://byui-cse.github.io/cse210-course-2023/unit01/csharp-2.html

        string letter = "A";
        bool passed = true;

        Console.WriteLine("What was your grade percentage in the class?");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letter = "A";
        } else if (grade >= 80)
        {
            letter = "B";
        } else if (grade >= 70)
        {
            letter = "C";
        } else if (grade >= 60)
        {
            letter = "D";
            passed = false;
        } else
        {
            letter = "F";
            passed = false;
        }

        Console.WriteLine($"Your letter grade is {letter}");
        
        if (passed)
        {
            Console.WriteLine("You passed!");
        } else
        {
            Console.WriteLine("You failed!");
        }

    }
}