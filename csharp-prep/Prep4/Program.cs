using System;

class Program
{
    static void Main(string[] args)
    {
        // assingment instructions
        // https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html

        Console.WriteLine("Enter a list of numbers:     (type '0' when finished)");

        List<int> numbers = new List<int>();
        int num;

        do
        {
            Console.Write("enter number:  ");
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                break;
            } else
            {
                numbers.Add(num);
            }

        } while (true);

        int sum = 0;
        int max = 0;
        foreach (int n in numbers)
        {
            sum += n;
            if (n > max) { max = n; }
        }
        int average = sum / numbers.Count;

        Console.WriteLine($"The Sum is:  {sum}");
        Console.WriteLine($"The Average is:  {average}");
        Console.WriteLine($"The Largest Number is:  {max}");

    }
}