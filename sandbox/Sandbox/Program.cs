using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        
        // Console.WriteLine("where do you want to save to?");
        // string filename = Console.ReadLine();
        
        // using (StreamWriter outputfile = new StreamWriter(filename))
        // {
        //     bool keepgoing = true;
        //     while (keepgoing)
        //     {
        //         string fulltext = "";
        //         Console.WriteLine("whats your favorite color?");
        //         string color = Console.ReadLine();
        //         fulltext += color + ":";
                
        //         Console.WriteLine("whats your favorite number?");
        //         int number = int.Parse(Console.ReadLine());
        //         fulltext += number + ":";
                
        //         Console.WriteLine("whats your favorite animal?");
        //         string animal = Console.ReadLine();
        //         fulltext += animal + ":";
                
        //         Console.WriteLine("whats your favorite state?");
        //         string state = Console.ReadLine();
        //         fulltext += state;
                
        //         outputfile.WriteLine(fulltext);
        //         Console.WriteLine(fulltext);
                
        //         Console.WriteLine("continue? press q to quit, anything else to continue");
        //         if (Console.ReadLine() == "q")
        //         {
        //             keepgoing = false;
        //         }
        //     }
        // }
        
        // -------------------------------------------------------------------
        
        // Console.WriteLine("where do you want to read from?");
        // string filename = Console.ReadLine();
        
        // string[] lines = System.IO.File.ReadAllLines(filename);
        
        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(":");
        //     string color = parts[0];
        //     string number = parts[1].ToString();
        //     string animal = parts[2];
        //     string state = parts[3];
        //     Console.WriteLine("COLOR - "+color);
        //     Console.WriteLine("NUMBER - "+number);
        //     Console.WriteLine("ANIMAL - "+animal);
        //     Console.WriteLine("STATE - "+state);
        // }
        
        string filename = "secondtry.txt";
        
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine("Added");
            sw.WriteLine("More");
            sw.WriteLine("stuff");
        }
        
        
        Console.WriteLine($"File contents: {File.ReadAllLines(filename)}");
        
        Console.WriteLine("Clear Contents???");
        Console.ReadLine();
        
        File.WriteAllText(filename, string.Empty);
        
        Console.WriteLine($"File contents: {File.ReadAllLines(filename)}");
        
        
        
    }
}