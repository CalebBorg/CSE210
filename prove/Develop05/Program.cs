using System;

class Program
{
    static void Main(string[] args)
    {
        int action = 0;
        string input;
        bool isNumber;
        Display display = new Display();
        while (action != 6){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            input = Console.ReadLine();

            isNumber = Int32.TryParse(input, out action);
            if (!isNumber){
                Console.WriteLine("Invalid input");
            }
            else{
                action = int.Parse(input);
                display.SetAction(action);


            switch(action){
                case 1:
                    int numberOfItems = 0;
                    int pointsPerItem = 0;
                    Console.WriteLine("What type of goal is this? Simple, Eternal, or Checklist?");
                    string type = Console.ReadLine().ToLower();
                    Console.WriteLine("Enter a description that will help you remember your goal.");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many points is this goal worth at completion?");
                    int points = int.Parse(Console.ReadLine());
                    if (type == "checklist"){
                        Console.WriteLine("How many items on the checklist?");
                        numberOfItems = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many points per item?");
                        pointsPerItem = int.Parse(Console.ReadLine());
                    }
                    display.CreateGoal(type, description, points, pointsPerItem, numberOfItems, true);
                    break;
                case 2:
                    display.DisplayGoals();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("Which goal number would you like to make a record of?");
                    int goalNumber = int.Parse(Console.ReadLine());
                    display.RecordEvent(goalNumber);
                    break;
                case 6:
                    break;
            }




            }
        }

        }
    }