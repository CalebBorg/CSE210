using System;
using System.Collections;
using System.ComponentModel;



class Program
{


    static void Main(string[] args)
    {
        Card draw = new Card("placeholder",1);
        Deck deck = new Deck();
        deck.Shuffle(deck.GetDeckList().Count());
        Table table = new Table();
        Stack stack0 = new Stack();
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();
        Stack stack3 = new Stack();
        Stack stack4 = new Stack();
        Stack stack5 = new Stack();
        Stack stack6 = new Stack();
        Stack stack7 = new Stack();
        Stack stack8 = new Stack();
        List<Stack> stacks = new List<Stack>{stack0,stack1,stack2,stack3,stack4,stack5,stack6,stack7,stack8};
        Display display = new Display();
        table.InitializeCardStacks(stacks);
        foreach(Stack stack in table.GetStacks()){
            while(true){
                draw = deck.DrawCard();
                if (draw.GetValue() > 10){
                    deck.AddCards(new List<Card>{draw});
                }
                else{
                    stack.PlaceCard(draw);
                    break;
                }
            }
        }
        deck.Shuffle(deck.GetDeckList().Count());
        bool pass;
        int score = 0;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(("GRIDCANNON").PadLeft(50));
        Console.WriteLine();
        Console.WriteLine("This is a game of card warfare where your battlefield is a 3x3 grid of cards. Your enemy are the royals, which surround the battlefield");
        Console.WriteLine("Cards may only be placed on cards of lower value.");
        Console.WriteLine("Royal cards must be placed on the outside of the 3x3 grid, adjacent to the card that closest resembles them");
        Console.WriteLine("Aces can be placed anywhere, and send the stack they're placed top of on to the bottom of the deck in order");
        Console.WriteLine("Cards placed on the edge of the grid will trigger cannon fire");
        Console.WriteLine("Royals across from a cannon trigger will take damage equal to the 2 cards between the trigger and the royal");
        Console.WriteLine("Jacks can be killed with 11 damage, Queens with 12 damage of their same color, Kings with 13 damage of their same suit");
        Console.WriteLine("If you run out of cards before the royals all die, you lose");
        Console.WriteLine("Cards that cannot be placed on the grid either increase your points or increase a royal's armor");
        Console.WriteLine("The primary goal is to kill all 12 royals, secondary goal is to end with as few points as possible");
        Console.WriteLine("Press 'enter' to continue");
        Console.ReadLine();

        while(true){
            if(deck.GetDeckList().Count() == 0){
                break;
            }
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            table.UpdateBoardState();
            Console.WriteLine(($"Score: {score}").PadLeft(12));
            display.DisplayBoard(table);
            draw = deck.DrawCard();
            if (draw.GetValue() <= 10){
                display.DisplayFodder(draw);
            }
            else{
                display.DisplayRoyal(draw);
            }
            Console.WriteLine();
            
            if (draw.GetValue() > 10){
                table.PlaceRoyal(draw);
            }

            else if (draw.GetValue() >= table.GetStack(0).GetTop().GetValue() || draw.GetValue() >= table.GetStack(1).GetTop().GetValue() || draw.GetValue() >= table.GetStack(2).GetTop().GetValue() || draw.GetValue() >= table.GetStack(3).GetTop().GetValue() || draw.GetValue() >= table.GetStack(4).GetTop().GetValue() || draw.GetValue() >= table.GetStack(5).GetTop().GetValue()|| draw.GetValue() >= table.GetStack(6).GetTop().GetValue() || draw.GetValue() >= table.GetStack(7).GetTop().GetValue() || draw.GetValue() >= table.GetStack(8).GetTop().GetValue() || draw.CheckIfAce()){
                Console.WriteLine("ON which stack would you like to place this card (indexes 1-9, left to right, top to bottom)?");
                pass = false;
                while (!pass){
                    string input = Console.ReadLine();
                    switch(input){
                        case "1":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(0,deck,stacks[0],draw);
                            table.GetStack(0).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(0).GetTop().GetValue()){
                            table.GetStack(0).PlaceCard(draw);
                            pass = true;
                        
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "2":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(1,deck,stacks[1],draw);
                            table.GetStack(1).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(1).GetTop().GetValue()){
                            table.GetStack(1).PlaceCard(draw);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "3":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(2,deck,stacks[2],draw);
                            table.GetStack(2).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(2).GetTop().GetValue()){
                            table.GetStack(2).PlaceCard(draw);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "4":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(3,deck,stacks[3],draw);
                            table.GetStack(3).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(3).GetTop().GetValue()){
                            table.GetStack(3).PlaceCard(draw);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "5":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(4,deck,stacks[4],draw);
                            table.GetStack(4).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(4).GetTop().GetValue()){
                            table.GetStack(4).PlaceCard(draw);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "6":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(5,deck,stacks[5],draw);
                            table.GetStack(5).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(5).GetTop().GetValue()){
                            table.GetStack(5).PlaceCard(draw);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "7":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(6,deck,stacks[6],draw);
                            table.GetStack(6).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(6).GetTop().GetValue()){
                            table.GetStack(6).PlaceCard(draw);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "8":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(7,deck,stacks[7],draw);
                            table.GetStack(7).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(7).GetTop().GetValue()){
                            table.GetStack(7).PlaceCard(draw);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "9":
                        if (draw.CheckIfAce()){
                            draw.ConscriptStack(8,deck,stacks[8],draw);
                            table.GetStack(8).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.GetValue() >= table.GetStack(8).GetTop().GetValue()){
                            table.GetStack(8).PlaceCard(draw);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        default:
                        Console.WriteLine("invalid input");
                        break;
                    }

                table.UpdateBoardState();
                if (pass){
                    table.CannonFire(int.Parse(input)-1,table.GetBoardState(),table.GetRoyalCourt());
                }
                }
            }
            else{
                bool occupied = false;
                Console.WriteLine("cannot place");
                foreach (Card royal in table.GetRoyalCourt()){
                    if (royal.GetValue() > 0){
                        occupied = true;
                    }
                }

            if (!occupied){
                score = score + draw.GetValue();
                Console.WriteLine($"Score increased by {draw.GetValue()}");
            }
            else{
                Console.WriteLine("Do you want to take the score increase or increase a royal's armor? Type 1 or 2.");
                while(true){
                    string scoreOrArmor = Console.ReadLine();
                    if (scoreOrArmor == "1"){
                        score = score + draw.GetValue();
                        break;
                    }
                    else if (scoreOrArmor == "2"){
                        Console.WriteLine($"Which royal do you want to give {draw.GetValue()} armor?");
                        foreach (Card royal in table.GetRoyalCourt()){
                            if (royal.GetValue() != 0){
                                Console.WriteLine($"{royal.GetFace()} of {royal.GetSuit()}, index {table.GetRoyalCourt().IndexOf(royal)+1}");
                            }
                        }

                    string input = Console.ReadLine();
                    int index;
                    bool isInt = int.TryParse(input,out index);
                    while(true){
                        if (!isInt){
                            Console.WriteLine("invalid input, not a valid index");
                        }
                        else{
                            index = int.Parse(input);
                            break;
                        }
                    }
                    while(true){
                        if (table.GetRoyalCourt()[index-1].GetValue() != 0){
                            table.ArmorRoyal(index,draw);
                            break;
                        }
                        else{
                            Console.WriteLine("invalid input, not a valid index");
                        }
                    }
                    break;
                        }
                        else{
                            Console.WriteLine("invalid input");
                        }
                }
            }
            }
        }
        if (table.GetKillList().Count() == 12){
           Console.WriteLine("OUT OF CARDS, ALL ROYALS DEAD     YOU WIN"); 
           Console.WriteLine($"Score: {score}");
           if (score == 0){
            Console.WriteLine("PERFECT GAME");
           }
        }
        else{
            Console.WriteLine("OUT OF CARDS     GAME OVER");
        }
    }



}