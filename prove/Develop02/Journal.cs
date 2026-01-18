using System.IO;
class Journal
{
    private List<Entry> _entries = new List<Entry>();
    string filename;

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine("-------");
        }
    }

    private void AppendEntry(Entry e)
    {
        _entries.Add(e);
    }

    public void ParseFileToJournal()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry e = new Entry();
            e.dateText = parts[0];
            e.prompt = parts[1];
            e.usertext = parts[2];
            AppendEntry(e);
        }
    }

    public void SaveEntry(Entry e)
    {
        AppendEntry(e);
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.Write($"{e.dateText}|");
            outputFile.Write($"{e.prompt}|");
            outputFile.Write($"{e.usertext}|");
        }
    }


}