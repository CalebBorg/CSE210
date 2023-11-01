using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int intPauseTime = 0;
        bool isNumber = false;
        while(!isNumber){
            Console.WriteLine("How many seconds do you need to read 1-3 lines of text? ");
            string input = Console.ReadLine();
            isNumber = Int32.TryParse(input, out intPauseTime);
            if (!isNumber){
                Console.WriteLine("Invalid input");
            }
            else{
                intPauseTime = int.Parse(input)*1000;
            }
        }


//CONTINUE AS LONG AS THE USER DOESN'T QUIT
        while(true){
            Console.WriteLine("What activity would you like to do today? ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("type 'quit' to quit");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit"){
                break;
            }

            int duration = 0;
            int inputInt;
//CHECK IF THE USER'S INPUT IS A NUMBER, IF IT ISN'T CATCH IT, AND IF IT IS CONTINUE
            isNumber = Int32.TryParse(input, out inputInt);
            if (isNumber){
//IF THEY CHOOSE 1, DO THE BREATHING EXERCISE
                if (inputInt == 1){
                    Console.WriteLine("How long do you want to do the activity?");
                    isNumber = false;
                    while(!isNumber){
                        isNumber = int.TryParse(Console.ReadLine(),out duration);
                        if(!isNumber){
                            Console.WriteLine("Invalid Input");
                        }
                    }
                    Breathing breathing = new Breathing(duration, intPauseTime);
                    breathing.DisplaySummary(breathing.GetName(), breathing.GetDescription());
                    breathing.Pause();
                    breathing.BreatheInAndOut();
                    breathing.DisplayEnd("Breathing Activity", duration);
                    breathing.Pause();
                }
//IF THEY CHOOSE 2 DO THE REFLECTION ACTIVITY
                else if (inputInt == 2){
                    Console.WriteLine("How long do you want to do the activity?");
                    isNumber = false;
                    while(!isNumber){
                        isNumber = int.TryParse(Console.ReadLine(),out duration);
                        if(!isNumber){
                            Console.WriteLine("Invalid Input");
                        }
                    }
                    Reflection reflection = new Reflection(duration, intPauseTime);
                    reflection.DisplaySummary(reflection.GetName(), reflection.GetDescription());
                    Console.WriteLine();
                    reflection.Pause();
                    reflection.DisplayRandomPrompt(reflection.GetPrompts());
                    reflection.Pause();
                    reflection.DisplayRandomQuestion(reflection.GetDuration());
                    reflection.DisplayEnd(reflection.GetName(), reflection.GetDuration());
                    reflection.Pause();
                }
//IF THEY CHOOSE 3 DO THE LISTING ACTIVITY
                else if (inputInt == 3){
                    Console.WriteLine("How long do you want to do the activity?");
                    isNumber = false;
                    while(!isNumber){
                        isNumber = int.TryParse(Console.ReadLine(),out duration);
                        if(!isNumber){
                            Console.WriteLine("Invalid Input");
                        }
                    }
                    Listing listing = new Listing(duration, intPauseTime);
                    listing.DisplaySummary(listing.GetName(), listing.GetDescription());
                    listing.Pause();
                    listing.DisplayRandomPrompt(listing.GetPrompts());
                    listing.SetInputs(listing.PromptInputs(listing.GetDuration()));
                    listing.CountInputs();
                    listing.DisplayEnd(listing.GetName(), listing.GetDuration());
                    listing.Pause();

                }
//IF THEY GAVE ANY OTHER INPUT ASK THEM FOR A DIFFERENT INPUT
                else {
                    Console.WriteLine("Invalid input.");
                }
            }
            else {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}


