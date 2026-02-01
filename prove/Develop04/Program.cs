using System;

class Program
{
    static void Main(string[] args)
    {
        bool breathingPicked = false;
        bool reflectPicked = false;
        bool listingPicked = false;
        
        Random random = new Random();
        
        int pick = random.Next(0,2);
        if (breathingPicked) {DoReflect();}
        else if (reflectPicked) {DoList();}
        else if (listingPicked)
        {
            if (pick == 0) {DoBreathe();}
            else if (pick == 1) {DoList();}
            else {DoReflect();}
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