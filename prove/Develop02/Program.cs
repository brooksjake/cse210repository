using System;

class Program
{
    // assignment instructions
    // https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
    static void Main(string[] args)
    {
        // Console.WriteLine(Environment.CurrentDirectory);

        Journal journal = new Journal();
        journal.ParseFileToJournal();
        Entry e = new Entry();
        e.prompt = "how was your day?";
        e.usertext = "it was fine.";
        journal.SaveEntry(e);

        Entry e1 = new Entry();
        e1.prompt = "other prompt";
        e1.usertext = "example text";
        journal.SaveEntry(e1);

        Entry e2 = new Entry();
        e2.prompt = "here is another bit";
        e2.usertext = "Here i journal";
        journal.SaveEntry(e2);



    }

    public void DisplayMenu()
    {
        
    }

}