using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        Fraction f1 = new Fraction(5);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(3,4);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(1,3);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Random rand = new Random();
        for (int i=0; i<20; i++)
        {
            int t = rand.Next(1,100);
            int b = rand.Next(1,100);
            Fraction f4 = new Fraction(t,b);
            Console.WriteLine(f4.GetFractionString());
            Console.WriteLine(f4.GetDecimalValue());
        }
    }
}