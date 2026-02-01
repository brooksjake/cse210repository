public class BreathingActivity : Activity
{
    private int _inhaleDuration;
    private int _exhaleDuration;
    
    public BreathingActivity()
    {
        setName("Relax by Deliberate Breathing");
        setDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        _inhaleDuration = 3;
        _exhaleDuration = 5;
    }
    
    public void RunActivity()
    {
        StartingMessage();
        Console.WriteLine("How long would you like to control your breathing?");
        _durationSeconds = int.Parse(Console.ReadLine());
        
        Console.WriteLine("-------------------------------");
        Console.WriteLine("sit still and close your eyes");
        Console.WriteLine("-------------------------------");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationSeconds);
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("inhale...");
            DisplayPauseFishAnimation(3);
            DisplayCountDownAnimation(_inhaleDuration);
            
            Console.WriteLine("exhale...");
            DisplayPauseFishAnimation(3);
            DisplayCountDownAnimation(_exhaleDuration);
        }
        
        EndingMessage();
    }
}