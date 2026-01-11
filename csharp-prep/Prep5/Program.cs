using System;

class Program
{
    static void Main(string[] args)
    {
        
        // assignment instructions
        // 

        String username;
        int favoritenumber;
        int birthyear;
        int numsquared;

        DisplayWelcome();
        username = PromptUserName();
        favoritenumber = PromptUserNumber();
        numsquared = SquareNumber(favoritenumber);
        PromptUserBirthYear(out birthyear);
        DisplayResults(username, numsquared, birthyear);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthyear)
    {
        Console.Write("Please enter the year you were born: ");
        birthyear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int i)
    {
        return i*i;
    }

    static void DisplayResults(String name, int i, int birthyear)
    {
        Console.WriteLine($"{name}, the square of your number is {i}");
        Console.WriteLine($"{name}, you will turn " + (2026 - birthyear) + " this year.");
    }
}