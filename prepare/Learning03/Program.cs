//usmapNameing System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        Fraction topFraction = new Fraction(5);
        Fraction fullFraction = new Fraction(3, 4);
        Fraction anotherFraction = new Fraction(1, 3);
        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(defaultFraction.GetDecimalValue());
        Console.WriteLine(topFraction.GetFractionString());
        Console.WriteLine(topFraction.GetDecimalValue());
        Console.WriteLine(fullFraction.GetFractionString());
        Console.WriteLine(fullFraction.GetDecimalValue());
        Console.WriteLine(anotherFraction.GetFractionString());
        Console.WriteLine(anotherFraction.GetDecimalValue());
    }
}
