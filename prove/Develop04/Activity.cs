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
        
    }
    
    protected void DisplayPauseAnimation(int animDuration)
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