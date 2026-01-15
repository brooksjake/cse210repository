public class Resume()
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"hiring consideration: {_name} \n    Jobs:");
        foreach (Job j in _jobs)
        {
            Console.Write("   ");
            j.Display();
        }
    }
}