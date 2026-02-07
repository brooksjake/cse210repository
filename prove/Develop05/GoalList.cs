using System.ComponentModel.DataAnnotations;

class GoalList
{
    private List<Goal> _goals;
    private int _userscore;
    private string filename;
    
    //constructor
    public GoalList()
    {
        _goals = new List<Goal>();
        _userscore = 0;
        filename = "allgoals.txt";
        ParseFileToList();
    }
    
    public int GetScore()
    {
        RefreshScore();
        return _userscore;
    }
    
    private void RefreshScore()
    {
        // reset the score, and re-add it up based on the completed value of each goal
        _userscore = 0;
        foreach (Goal goal in _goals)
        {
            _userscore += goal.GetValue();
        }
    }
    
    public void AddGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }
    
    public void AddCompletion(int pick)
    {
        if (pick > 0 && pick  <= _goals.Count)
        {
            _goals[pick-1].Complete();
            Console.WriteLine("completion event added");
        } else
        {
            Console.WriteLine("that goal doesn't exist");
        }
    }
    
    public void DisplayGoals()
    {
        RefreshFile();
        Console.WriteLine("------------ Goal List ------------");
        if (_goals.Count == 0)
        {
            Console.WriteLine("(you have no goals yet)");
            return;
        }
        foreach (Goal goal in _goals)
        {
            Console.WriteLine((_goals.IndexOf(goal)+1).ToString() + ".) Goal: "+goal.GetText());
            Console.WriteLine("Completed: "+goal.GetCompleted());
            Console.WriteLine("------------");
        }
    }
    
    private void RefreshFile()
    {
        File.WriteAllText(filename, string.Empty);
        using (StreamWriter scribe = new StreamWriter(filename, true))
        {
            foreach (Goal goal in _goals)
            {
                scribe.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    
    private void ParseFileToList()
    {
        if (File.Exists(filename) == false) // checks if the file already exists
        {
            // if it doesn't, make it
            using (File.Create(filename)) {}
        }
        
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines) // separate each goal string representation
        {
            string[] parts = line.Split(":"); // separate the goal's string representation into its parts
            
            if (parts.Length == 3) // 3 parts means it's a SimpleGoal
            {
                SimpleGoal sg;
                string goalText = parts[0];
                int basePointValue = int.Parse(parts[1]);
                sg = new SimpleGoal(goalText, basePointValue);
                if (parts[2] == "true")
                {
                    sg.Complete();
                }
                _goals.Add(sg);
                
            } else if (parts.Length == 4) // 4 parts means it's an EternalGoal
            {
                EternalGoal eg;
                string goalText = parts[0];
                int basePointValue = int.Parse(parts[1]);
                eg = new EternalGoal(goalText, basePointValue);
                
                int timesCompleted = int.Parse(parts[3]);
                for (int i = 0; i < timesCompleted; i++)
                {
                    eg.Complete();
                }
                _goals.Add(eg);
                
            } else if (parts.Length == 6) // 6 parts means it's a ChecklistGoal
            {
                ChecklistGoal cg;
                string goalText = parts[0];
                int basePointValue = int.Parse(parts[1]);
                int desiredTimes = int.Parse(parts[4]);
                int bonusValue = int.Parse(parts[5]);
                cg = new ChecklistGoal(goalText, basePointValue, desiredTimes, bonusValue);
                
                int timesCompleted = int.Parse(parts[3]);
                for (int i = 0; i < timesCompleted; i++)
                {
                    cg.Complete();
                }
                _goals.Add(cg);
                
            } else
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(line);
            }
        }
    }
}