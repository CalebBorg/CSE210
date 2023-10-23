using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment thing = new MathAssignment("Jacob", "Math", "Section 8", "11-15");
        Console.WriteLine(thing.GetSummary());
        Console.WriteLine(thing.GetHomeworkList()[0] + " " +  thing.GetHomeworkList()[1]);

        WritingAssignment thing2 = new WritingAssignment("Mary", "English", "The Problem with War");
        Console.WriteLine(thing2.GetSummary());
        Console.WriteLine(thing2.GetWritingInfo());
    }
}

