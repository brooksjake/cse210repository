public class ListingActivty : Activity
{
    private List<string> _prompts;
    private List<string> _responseItems;
    private Random random;
    
    // constructor
    public ListingActivty()
    {
        setName("Relax by Gratitude Listing");
        setDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _prompts = new List<string>();
        _responseItems = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("When did you feel peace or clarity this month?");
        _prompts.Add("Who has made a positive impact on your life recently?");
        random = new Random();
    }
    
    
    public void RunActivity()
    {
        StartingMessage();
        Console.WriteLine("How long would you like to spend listing?");
        _durationSeconds = int.Parse(Console.ReadLine());
        
        Console.WriteLine("-------------------------------");
        string promptpick = _prompts[random.Next(0,_prompts.Count)];
        Console.WriteLine(promptpick);
        Console.WriteLine("Take a moment to think about it...");
        DisplayPauseFishAnimation(7);
        DisplayCountDownAnimation(5);
        Console.WriteLine("now start listing!");
        Console.WriteLine("-------------------------------");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationSeconds);
        
        while (DateTime.Now < endTime)
        {
            _responseItems.Add(Console.ReadLine());
        }
        
        Console.WriteLine("Awesome! You listed "+_responseItems.Count+" things!");
        EndingMessage();
    }
}