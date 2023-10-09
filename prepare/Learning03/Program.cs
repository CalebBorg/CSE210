using System;

class Program
{
    static void Main(string[] args)
    {
        while(1 == 1){
            Fraction fraction = new Fraction();
            fraction.SetTop();
            fraction.SetBottom();
            Console.WriteLine(fraction.GetFractionString());
            Console.WriteLine(fraction.GetDecimalValue());
        }
    }
}