using System;

class Program
{
    static void Main(string[] args)
    {
            Fraction fraction = new Fraction();
            Console.WriteLine(fraction.GetFractionString());
            Console.WriteLine(fraction.GetDecimalValue());
            fraction.SetTop();
            Console.WriteLine(fraction.GetFractionString());
            Console.WriteLine(fraction.GetDecimalValue());
            fraction.SetTop();
            fraction.SetBottom();
            Console.WriteLine(fraction.GetFractionString());
            Console.WriteLine(fraction.GetDecimalValue());
    }
}