class Entry()
{
    public string dateText = DateTime.Now.ToShortDateString();
    public string prompt;
    public string usertext;

    public void Display()
    {
        Console.WriteLine($"Date: {dateText}");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine(usertext);
    }


}