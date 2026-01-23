class Word
{
    private String word;
    private String blank;
    private bool hidden = false;

    public Word(String w)
    {
        word = w;
        SetBlank();
    }

    private void SetBlank()
    {
        blank = "";
        for (int i = 0; i<word.Length; i++)
        {
            blank+="_";
        }
    }

    public String GetText()
    {
        if (hidden)
        {
            return blank;
        } else
        {
            return word;
        }
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }
}