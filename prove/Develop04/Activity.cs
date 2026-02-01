public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _durationSeconds;
    protected string _endMessage;
    
    protected void StartingMessage()
    {
        Console.WriteLine("Welcome to the -"+_activityName+" !");
        Console.WriteLine(_activityDescription);
    }
    
    protected void setDescription(string description)
    {
        _activityDescription = description;
    }
    
    protected void setName(string name)
    {
        _activityName = name;
    }
    
    protected void EndingMessage()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Well done! Thank you for your participation");
    }
    
    protected void DisplayCountDownAnimation(int animDuration)
    {
        for (int i = animDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            
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
    
    protected void DisplayPauseFishAnimation(int animDuration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(animDuration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Thread.Sleep(200);
            Console.Write("\b \b");
            
            Console.Write(" >");
            Thread.Sleep(200);
            Console.Write("\b \b\b");
            
            Console.Write("  >");
            Thread.Sleep(200);
            Console.Write("\b \b\b\b");
            
            Console.Write("   >");
            Thread.Sleep(200);
            Console.Write("\b \b\b\b\b");
            
            Console.Write("    >");
            Thread.Sleep(200);
            Console.Write("\b \b\b\b\b\b");
            
            Console.Write("    <");
            Thread.Sleep(200);
            Console.Write("\b \b\b\b\b\b");

            Console.Write("   <");
            Thread.Sleep(200);
            Console.Write("\b \b\b\b\b");
            
            Console.Write("  <");
            Thread.Sleep(200);
            Console.Write("\b \b\b\b");
            
            Console.Write(" <");
            Thread.Sleep(200);
            Console.Write("\b \b\b");
            
            Console.Write("<");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }
}