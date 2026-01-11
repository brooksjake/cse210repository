using System;

class Program
{
    static void Main(string[] args)
    {

        // assignment instructions
        // https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html

        Console.WriteLine("Guess the magic number between 1 and 100!");
        Random random = new Random();
        int num = random.Next(1, 100);
        int guess;

        int count = 0;
        
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count += 1;

            if (guess == num)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine("it took " + count + " guesses");
            } else if (guess > num)
            {
                Console.WriteLine("Lower");
            } else
            {
                Console.WriteLine("Higher");
            }

        } while (guess != num);
    }
}