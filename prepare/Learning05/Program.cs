using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Square sq = new Square("blue", 4);
        Console.WriteLine(sq.GetColor());
        Console.WriteLine(sq.GetArea());
        
        Rectangle rec = new Rectangle("green", 3,5);
        Console.WriteLine(rec.GetColor());
        Console.WriteLine(rec.GetArea());
        
        Circle circ = new Circle("pink", 2);
        Console.WriteLine(circ.GetColor());
        Console.WriteLine(circ.GetArea());
    }
}