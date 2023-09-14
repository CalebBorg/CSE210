using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
//DEFINE VARIABLES
        string userInput;
        int percentage;
        string letter;
        bool pass = true;

//ASK USER FOR THEIR PERCENTAGE, STORE AS userInput
        Console.Write("Enter your percentage grade: ");
        userInput = Console.ReadLine();
        percentage = int.Parse(userInput);

//CHECK WHICH LETTER GRADE STUDENT SHOULD RECIEVE, AND WHETHER THAT IS A PASSING GRADE
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
            pass = false;
        }
        else if (percentage < 60)
        {
            letter = "F";
            pass = false;
        }
        else
        {
            letter = "error";
        }

//PRINT LETTER GRADE, CHECK IF STUDENT PASSED AND PRINT OUT APPROPRIATE STATEMENT
        Console.WriteLine($"Your letter grade is {letter}.");
        if (pass == true)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but there's always next semester.");
        }



    }
}