public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _reflectionQuestions;
    private Random random;
    
    // constructor
    public ReflectionActivity()
    {
        setName("Relax by Reflection");
        setDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts = new List<string>();
        _reflectionQuestions = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you overcame fear.");
        _prompts.Add("Think of a time when you made someone smile.");
        _prompts.Add("Think of a time when you learned something the hard way.");
        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
        random = new Random();
    }
    
    public void RunActivity()
    {
        StartingMessage();
        Console.WriteLine("How long would you like to reflect?");
        _durationSeconds = int.Parse(Console.ReadLine());
        
        Console.WriteLine("-------------------------------");
        string promptpick = _prompts[random.Next(0,_prompts.Count)];
        Console.WriteLine(promptpick);
        DisplayPauseFishAnimation(7);
        DisplayCountDownAnimation(5);
        Console.WriteLine("-------------------------------");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationSeconds);
        
        while (DateTime.Now < endTime)
        {
            string questionpick = _reflectionQuestions[random.Next(0,_reflectionQuestions.Count)];
            Console.WriteLine(questionpick);
            string response = Console.ReadLine();
            Console.WriteLine("------");
            DisplayPauseFishAnimation(4);
        }
        
        EndingMessage();
        
    }
}