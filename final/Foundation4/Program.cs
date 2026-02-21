using System;

class Program
{
    static void Main(string[] args)
    {
        
        Running runningEvent = new Running(new DateOnly(2025, 11, 3), 30, 3.0);

        Cycling cyclingEvent = new Cycling(new DateOnly(2025, 11, 4), 45, 15.0);

        Swimming swimmingEvent = new Swimming(new DateOnly(2025, 11, 5), 20, 20);

        
        List<Activity> activities = new List<Activity> {runningEvent, cyclingEvent, swimmingEvent};
        
        Console.WriteLine("EXERCISE TRACKING:");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}