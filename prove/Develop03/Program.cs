using System;
using System.Dynamic;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
//ASSIGN AN OBJECT OF EACH CLASS AND INITIALIZE numberOfRounds
        Word Word1 = new Word();
        Reference Reference1 = new Reference();
        Scripture Scripture1 = new Scripture();
        int numberOfRounds = 0;

//ASK THE USER FOR THEIR REFERENCE, SCRIPTURE, AND NUMBER OF HIDDEN WORDS PER ROUND
        Console.WriteLine("Input your scripture reference:");
        string reference = Console.ReadLine();
        Reference1.SetReference(reference);
        Console.WriteLine();

        Console.WriteLine("Input your scripture:");
        string scripture = Console.ReadLine();
        Scripture1.SetScripture(scripture);
        Console.WriteLine();

        Console.WriteLine("Input the number of words you want hidden per round:");
        int numberOfHides = int.Parse(Console.ReadLine());
        Word1.SetNumberOfHides(numberOfHides);
        Console.WriteLine();
        Console.WriteLine();

        Scripture1.SetWordList(Scripture1.StrToList(scripture));


        Console.WriteLine();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(Reference1.GetReference());
        Console.WriteLine(Scripture1.GetScripture());
        string menuChoice;

//AS LONG AS THE USER DOESN'T WANT TO QUIT AND THERE ARE MORE WORDS TO HIDE, KEEP GOING THROUGH THIS LOOP
            while (Scripture1.GetWordCount() > (numberOfHides*numberOfRounds)){
                Console.WriteLine("Type 'quit' to end program. Type anything else to continue");
                Console.WriteLine();
                menuChoice = Console.ReadLine();
                if (menuChoice.ToLower() == "quit"){
                    break;
                }
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(Reference1.GetReference());
//THIS CALLS THE FUNCTION TO HIDE A NUMBER OF WORDS IN THE LIST OF STRINGS
                Scripture1.SetWordList(Scripture1.HideWords(Word1.GetNumberOfHides()));
//TURNS THE NOW PARTIALLY HIDDEN LIST OF STRINGS BACK INTO A STRING AND PRINTS IT
                Console.WriteLine(Scripture1.ListToStr(Scripture1.GetWordList()));
                numberOfRounds++;

            }
    }
}