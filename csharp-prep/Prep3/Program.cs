using System;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
//DEFINE VARIABLES, INCLUDING randomGenerator
        string play = "yes";
        int magicNumber;
        int guess = 0;
        int numberOfGuesses = 0;
        Random randomGenerator = new Random();

//WHILE PLAYER WANTS TO KEEP PLAYING, CONTINUE THE GAME
        while(play == "yes" || play == "Yes" || play == "YES")
        {

//DEFINE THE MAGIC NUMBER AS A NUMBER BETWEEN 1 AND 100
            magicNumber = randomGenerator.Next(1,100);
            Console.WriteLine(magicNumber);

//WHILE THE GUESS AND THE MAGIC NUMBER ARE NOT THE SAME, KEEP GIVING HINTS
            while(guess != magicNumber)
            {
                Console.WriteLine("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

//CHECK IF THE GUESS IS HIGHER THAN, LOWER THAN, OR EQUAL TO THE MAGIC NUMBER, THEN PRINT FEEDBACK
                if(guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You did it! It took you {numberOfGuesses} guesses!");
                }
            }
//CHECK IF USER STILL WANTS TO PLAY AND RESET GUESS COUNTER
            Console.WriteLine("Do you want to contine playing? Type 'yes' to continue, type anything else to quit");
            play = Console.ReadLine();
            numberOfGuesses = 0;
        }
    }
}