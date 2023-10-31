using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
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

            int duration;
            int inputInt;
            bool isNumber = Int32.TryParse(input, out inputInt);
            if (isNumber){
                if (inputInt == 1){
                    int timer = 0;
                    Console.WriteLine("How long do you want to do the activity?");
                    duration = int.Parse(Console.ReadLine());
                    Breathing breathing = new Breathing(duration, 5);
                    breathing.DisplaySummary("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    int cycles = 0;
                    Thread.Sleep(5000);
                    while(timer < duration){
                        Console.Clear();
                        if (cycles%2 > 0){
                            Console.WriteLine("Breathe Out... ");
                        }
                        else {
                            Console.WriteLine("Breathe In... ");
                        }
                        breathing.Countdown(5);
                        cycles ++;
                        timer = timer + 5;
                    }
                    breathing.DisplayEnd("Breathing Activity", duration);
                    Thread.Sleep(5000);
                }
                else if (inputInt == 2){
                    Console.WriteLine("How long do you want to do the activity?");
                    duration = int.Parse(Console.ReadLine());
                    Reflection reflection = new Reflection(duration, 5);
                    reflection.DisplaySummary("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Console.WriteLine();
                    Thread.Sleep(5000);
                    reflection.DisplayRandomPrompt();
                    reflection.DisplayRandomQuestion(duration);
                    reflection.DisplayEnd("Reflection Activity", duration);
                    Thread.Sleep(5000);
                }
                else if (inputInt == 3){
                    Console.WriteLine("How long do you want to do the activity?");
                    duration = int.Parse(Console.ReadLine());
                    Listing listing = new Listing(duration, 5);
                    listing.DisplaySummary("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    Thread.Sleep(5000);
                    listing.DisplayRandomPrompt();
                    List<string> inputList = listing.PromptInputs(duration);
                    Console.WriteLine($"You listed {inputList.Count()} things.");
                    listing.DisplayEnd("Listing Activity", duration);
                    Thread.Sleep(5000);

                }
                else {
                    Console.WriteLine("Invalid input.");
                    Thread.Sleep(2000);
                }
            }
            else {
                Console.WriteLine("Invalid input.");
                Thread.Sleep(2000);
            }
        }
    }
}


