using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2004;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Microsoft";
        job2._startYear = 1998;
        job2._endYear = 2015;

        Resume r1 = new Resume();
        r1._name = "Jimathan Janiels";
        r1._jobs.Add(job1);
        r1._jobs.Add(job2);

        r1.Display();
    }
}