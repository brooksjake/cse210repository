using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int animDuration = 200;
        for (int i = animDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500);
            
            if (i < 10)
            {
                Console.Write("\b \b");
            } else if (i < 100)
            {
                Console.Write("\b \b\b");
            } else {
                Console.Write("\b \b\b\b");
            }
        }
    }
}