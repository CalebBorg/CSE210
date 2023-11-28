using System;
using System.Collections;
using System.ComponentModel;



class Program
{


    static void Main(string[] args)
    {
        Card draw = new Card("placeholder",1);
        Deck deck = new Deck();
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
            draw = deck.DrawCard();
            while(draw.GetValue() > 10){
                draw = deck.DrawCard();
            }
            stack.PlaceCard(draw);
        }
        bool pass;
        int score = 0;
        Console.OutputEncoding = System.Text.Encoding.UTF8;



        while(true){
            Console.WriteLine();
            Console.WriteLine();
            table.UpdateBoardState();
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
                Console.WriteLine("Where would you like to place this card?");
                pass = false;
                while (!pass){
                    string input = Console.ReadLine();
                    switch(input){
                        case "1":
                        if (draw.GetValue() >= table.GetStack(0).GetTop().GetValue()){
                            table.GetStack(0).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(0).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "2":
                        if (draw.GetValue() >= table.GetStack(1).GetTop().GetValue()){
                            table.GetStack(1).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(1).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "3":
                        if (draw.GetValue() >= table.GetStack(2).GetTop().GetValue()){
                            table.GetStack(2).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(2).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "4":
                        if (draw.GetValue() >= table.GetStack(3).GetTop().GetValue()){
                            table.GetStack(3).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(3).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "5":
                        if (draw.GetValue() >= table.GetStack(4).GetTop().GetValue()){
                            table.GetStack(4).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(4).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "6":
                        if (draw.GetValue() >= table.GetStack(5).GetTop().GetValue()){
                            table.GetStack(5).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(5).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "7":
                        if (draw.GetValue() >= table.GetStack(6).GetTop().GetValue()){
                            table.GetStack(6).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(6).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "8":
                        if (draw.GetValue() >= table.GetStack(7).GetTop().GetValue()){
                            table.GetStack(7).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(7).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
                            pass = true;
                        }
                        else{
                            Console.WriteLine("cannot place card of lower value on card of greater value");
                        }
                        break;

                        case "9":
                        if (draw.GetValue() >= table.GetStack(8).GetTop().GetValue()){
                            table.GetStack(8).PlaceCard(draw);
                            pass = true;
                        }
                        else if (draw.CheckIfAce()){
                            table.GetStack(8).PlaceCard(draw);
                            draw.ConscriptStack(0,deck,stacks[0]);
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
                            Console.WriteLine("invalid input, not an integer");
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
                            Console.WriteLine("not a valid index");
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
            
            Console.Clear();
        }
    }



}