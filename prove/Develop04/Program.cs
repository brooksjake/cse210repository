using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool breathingPicked = false;
        bool reflectPicked = false;
        bool listingPicked = false;
        
        Random random = new Random();
        while (true)
        {
            int pick = random.Next(0,2);
            if (!breathingPicked) {DoBreathe(); breathingPicked=true;}
            else if (!reflectPicked) {DoReflect(); reflectPicked=true;}
            else if (!listingPicked)
            {
                if (pick == 0) {DoBreathe(); breathingPicked=true;}
                else if (pick == 1) {DoList();}
                else {DoReflect();}
                
            }
        }
    }
    
    public static void DoBreathe()
    {
        BreathingActivity b = new BreathingActivity();
        b.RunActivity();
    }
    
    public static void DoReflect()
    {
        ReflectionActivity r = new ReflectionActivity();
        r.RunActivity();
    }
    
    public static void DoList()
    {
        ListingActivty l = new ListingActivty();
        l.RunActivity();
    }
}