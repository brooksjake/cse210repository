class Reference
{
    private String _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    public Reference(String book, int chapter, int startverse)
    {
        _book = book; _chapter = chapter; _startverse = startverse; _endverse = 0;
    }

    public Reference(String book, int chapter, int startverse, int endverse)
    {
        _book = book; _chapter = chapter; _startverse = startverse; _endverse = endverse;
    }

    public String GetFullRef()
    {
        String full = _book + " " + _chapter.ToString() + ":" + _startverse.ToString();
        if (_endverse != 0)
        {
            full += "-" + _endverse.ToString();
        }
        return full;

    }
}