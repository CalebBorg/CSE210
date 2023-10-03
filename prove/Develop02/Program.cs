using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        int menuChoice = 0;
        bool fileNameValid = false;
        DateTime currentDateAndTime = DateTime.Now;
        string DateTimeString = currentDateAndTime.ToString("MM/dd/yyyy");

//GET A FILENAME FROM THE USER AND ONLY MOVE ON IF IT EXISTS
        while (fileNameValid == false){
            try{
                Console.WriteLine("What is the name of the file you would like to open? ");
                Journal._fileName = Console.ReadLine();
                Journal.InitializeJournal(Journal._fileName, Journal._journalEntries);
                fileNameValid = true;
            }
            catch(Exception badFileName){
                Console.WriteLine(badFileName.Message);
                fileNameValid = false;

            }
        }



//DISPLAY MENU AFTER EVERY ACTION AS LONG AS PROGRAM IS RUNNING
        while(menuChoice !=5){
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 Load File (make sure to save current file first)");
            Console.WriteLine("2 Display Journal");
            Console.WriteLine("3 New Entry");
            Console.WriteLine("4 Save Journal");
            Console.WriteLine("5 Quit");
            bool menuChoiceValid = false;
            while (menuChoiceValid == false)
                try{
                    menuChoice = int.Parse(Console.ReadLine());
                    menuChoiceValid = true;
                }
                catch(Exception b){
                    Console.WriteLine(b.Message);
                }  

//CLEAR THE CURRENT SAVED JOURNAL ENTRIES AND OPEN THE NEW FILE
            if (menuChoice == 1){
                Journal._journalEntries.Clear();
                fileNameValid = false;
                while (fileNameValid == false){
                    try{
                        Console.WriteLine("What is the name of the file you would like to open? ");
                        Journal._fileName = Console.ReadLine();
                        Journal.InitializeJournal(Journal._fileName, Journal._journalEntries);
                        fileNameValid = true;
                    }
                    catch(Exception badFileName){
                        Console.WriteLine(badFileName.Message);
                        fileNameValid = false;

                    }
                }
            }
//PRINT OUT EACH JOURNAL ENTRY ON ITS OWN LINE
            else if (menuChoice == 2){
                foreach (string entry in Journal._journalEntries){
                    Console.WriteLine(entry);
                }
            }
//DISPLAY A WRITING PROMPT, TAKE THE USER'S INPUT, THEN STORE IT IN THE LIST OF JOURNAL ENTRIES
            else if (menuChoice == 3){
                NewEntry.DisplayPrompt(NewEntry._randomNumber, NewEntry._writingPrompts);
                NewEntry._newEntry = DateTimeString + " " + Console.ReadLine();
                Journal._journalEntries = NewEntry.StoreEntry(NewEntry._newEntry , Journal._journalEntries);
            }
//DELETE EVERYTHING IN THE CURRENT FILE AND WRITE OVER IT WITH THE CURRENT SAVED JOURNAL ENTRIES
            else if (menuChoice == 4){
                Journal.RefreshFile(Journal._fileName, Journal._journalEntries);
            }
//PASSES BACK TO THE BEGINNING OF THE LOOP AND ENDS IT
            else if (menuChoice == 5){
            }
//TELL THE USER THAT THEIR INPUT WAS INVALID
            else{
                Console.WriteLine("Invalid Request");
            }
        }
    }
}