using System;



class Program
{



    static void CBdisplayWelcome()
{
    Console.WriteLine("Welcome to the Program!");
}
static string CBpromptUserName()
{
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    return userName;
}
static int CBpromptUserNumber()
{
    Console.Write("Please enter your favorite number: ");
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}
static int CBsquareNumber(int number)
{
    int numberSquared = number*number;
    return numberSquared;
}
static void CBdisplayResult(string userName, int numberSquared)
{
    Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
}








    static void Main(string[] args)
    {
        CBdisplayWelcome();
        string userName = CBpromptUserName();
        int userNumber = CBpromptUserNumber();
        int numberSquared = CBsquareNumber(userNumber);
        CBdisplayResult(userName, numberSquared);


    }
}



/*
    DisplayWelcome - Displays the message, "Welcome to the Program!"
    PromptUserName - Asks for and returns the user's name (as a string)
    PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    DisplayResult - Accepts the user's name and the squared number and displays them.
*/