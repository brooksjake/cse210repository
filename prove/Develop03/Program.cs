using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Console.Clear();
        Reference ref1 = new Reference("Alma", 7, 11);
        Scripture skip1 = new Scripture(ref1, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.");

        Reference ref2 = new Reference("John", 3,5);
        Scripture skip2 = new Scripture(ref2, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");

        Reference ref3 = new Reference("Moroni", 10, 3,5);
        Scripture skip3 = new Scripture(ref3, "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");

        scriptures.Add(skip1);
        scriptures.Add(skip2);
        scriptures.Add(skip3);

        Random randal = new Random();
        int pickindex = randal.Next(0,scriptures.Count);

        Console.WriteLine("Welcome to the scripture memorizer!");
        bool keepgoing = true;
        while (keepgoing)
        {
            Console.WriteLine("press Q to quit");
            Console.WriteLine("----------------------------------");
            scriptures[pickindex].Display();
            Console.WriteLine("\n----------------------------------");

            if (Console.ReadLine() == "q")
            {
                Console.WriteLine("Goodbye!");
                keepgoing = false;
            } else
            {
                if (scriptures[pickindex].CompletelyHidden() == true)
                {
                    Console.Clear();
                    Console.WriteLine("no more words to hide");
                }
                else
                {
                    scriptures[pickindex].HideSomeWords();
                    Console.Clear();
                }
            }
        }

    }


}