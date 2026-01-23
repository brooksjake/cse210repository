class Scripture
{
    private String _fullText;
    private List<Word> _words;
    private Reference _reference;
    private Random randy = new Random();
    private int hiddenCount = 0;

    public Scripture(Reference reference, String inputText)
    {
        _reference = reference;
        _fullText = inputText;
        _words = new List<Word>();
        ParseTextToWords();
    }

    private void ParseTextToWords()
    {
        String[] parts = _fullText.Split(' ');
        foreach (String part in parts)
        {
            Word w = new Word(part);
            _words.Add(w);
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetFullRef());
        foreach (Word w in _words)
        {
            Console.Write(w.GetText() + " ");
        }
    }

    public void HideSomeWords()
    {
        int n = 0;
        do
        {
            int indexpick = randy.Next(0, _words.Count);
            if (_words[indexpick].IsHidden() == false)
            {
                _words[indexpick].Hide();
                hiddenCount++;
                n++;
            }
        } while (n < 2);
    }

    public bool CompletelyHidden()
    {
        return hiddenCount >= _words.Count-1;
    }

}