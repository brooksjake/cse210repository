using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reffy = new Reference("Alma", 7, 11);
        Scripture skippy = new Scripture(reffy, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.");

        Console.WriteLine("Welcome to the scripture memorizer!");
        bool keepgoing = true;
        while (keepgoing)
        {
            Console.WriteLine("press Q to quit");
            Console.WriteLine("----------------------------------");
            skippy.Display();
            Console.WriteLine("\n----------------------------------");

            if (Console.ReadLine() == "q")
            {
                Console.WriteLine("Goodbye!");
                keepgoing = false;
            } else
            {
                if (skippy.CompletelyHidden() == true)
                {
                    Console.Clear();
                    Console.WriteLine("no more words to hide");
                }
                else
                {
                    skippy.HideSomeWords();
                    Console.Clear();
                }
            }
        }

    }


}