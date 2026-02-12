class Video
{
    private string _author;
    private string _title;
    private int _lengthMinutes;
    public List<Comment> _comments;
    
    public Video(string author, string title, int lengthMinutes)
    {
        _author = author;
        _title = title;
        _lengthMinutes = lengthMinutes;
        _comments = new List<Comment>();
    }
    
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    
    public void Display()
    {
        Console.WriteLine("-------------------- Video");
        Console.WriteLine("    Author: "+_author);
        Console.WriteLine("    Title: "+_title);
        Console.WriteLine("    Lenght: "+_lengthMinutes+" minutes");
        Console.WriteLine(GetCommentCount() + " comments");
        foreach (Comment c in _comments)
        {
            Console.WriteLine((_comments.IndexOf(c)+1).ToString() + ".) author- " + _author);
            Console.WriteLine("'"+c.GetText()+"'");
        }
    }
}