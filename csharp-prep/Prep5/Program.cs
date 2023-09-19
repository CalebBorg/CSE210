using System;



class Program
{



    static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the Program!");
}
static string PromptUserName()
{
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    return userName;
}
static int PromptUserNumber()
{
    Console.Write("Please enter your favorite number: ");
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}
static int SquareNumber(int number)
{
    int numberSquared = number*number;
    return numberSquared;
}
static void DisplayResult(string userName, int numberSquared)
{
    Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
}








    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, numberSquared);


    }
}



/*
    DisplayWelcome - Displays the message, "Welcome to the Program!"
    PromptUserName - Asks for and returns the user's name (as a string)
    PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    DisplayResult - Accepts the user's name and the squared number and displays them.
*/