using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalList _goalList = new GoalList();
        Console.WriteLine("Hello, welcome to the Goals Tracker Program!");
        _goalList.DisplayGoals();
        
        bool keepgoing = true;
        while (keepgoing)
        {
            DisplayMenu();
            string response = Console.ReadLine();
            
            if (response == "c")
            {
                Console.WriteLine("from the list above, insert the number of the goal you want to complete");
                int pick = int.Parse(Console.ReadLine());
                _goalList.AddCompletion(pick);
                
            } else if (response == "a")
            {
                Console.WriteLine("insert '1' to create a SimpleGoal");
                Console.WriteLine("insert '2' to create an EternalGoal");
                Console.WriteLine("insert '3' to create a ChecklistGoal");
                
                int pick = int.Parse(Console.ReadLine());
                if (pick == 1)
                {
                    Console.WriteLine("What will your new simple goal be?");
                    string text = Console.ReadLine();
                    
                    Console.WriteLine("How many points will this goal be worth?");
                    int points = int.Parse(Console.ReadLine());
                    
                    _goalList.AddGoal(new SimpleGoal(text, points));
                    
                } else if (pick == 2)
                {
                    Console.WriteLine("What will your new eternal goal be?");
                    string text = Console.ReadLine();
                    
                    Console.WriteLine("How many points will this goal be worth?");
                    int points = int.Parse(Console.ReadLine());
                    
                    _goalList.AddGoal(new EternalGoal(text, points));
                    
                } else if (pick == 3)
                {
                    Console.WriteLine("What will your new checklist goal be?");
                    string text = Console.ReadLine();
                    
                    Console.WriteLine("How many points will this goal be worth?");
                    int points = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("How many times do you aim to complete this goal?");
                    int times = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"And how much will the bonus be for completing your goal {times} times?");
                    int bonus = int.Parse(Console.ReadLine());
                    
                    _goalList.AddGoal(new ChecklistGoal(text, points, times, bonus));
                } else
                {
                    Console.WriteLine("um, that wasn't an option");
                }
                
            } else if (response == "d") 
            {
                _goalList.DisplayGoals();
                
            } else
            {
                keepgoing = false;
                Console.WriteLine("goodbye!");
                return;
            }
        }
        
        void DisplayMenu()
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("USERSCORE: "+_goalList.GetScore().ToString());
            Console.WriteLine("insert 'c' to complete a goal");
            Console.WriteLine("insert 'a' to add a new goal");
            Console.WriteLine("insert 'd' to view goals again");
            Console.WriteLine("insert 'q' to quit");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
        }

    }

}