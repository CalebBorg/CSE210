using System.Runtime.InteropServices;

public class Display{

//DISPLAYS THE INFORMATION OF A ROYAL CARD, FORMATTED TO ALWAYS BE THE SAME SIZE AS EVERY OTHER CARD
public void DisplayRoyal(Card royal){
    if (royal.GetValue() != 0){
        if (royal.GetArmor() > 0){
            Console.Write($"[{(royal.GetFace() + '+' + royal.GetArmor()).PadRight(8)}{royal.GetSuit().PadLeft(0)} ]");
        }
        else{
            Console.Write($"[{royal.GetFace().PadRight(8)}{royal.GetSuit().PadLeft(0)} ]");
            
        }
    }
    else{
        Console.Write("            ");
    }
}

//DISPLAYS THE INFORMATION OF A FODDER CARD, FORMATTED TO ALWAYS BE THE SAME SIZE AS EVERY OTHER CARD
public void DisplayFodder(Card fodder){
    Console.Write($"[{fodder.GetValue().ToString().PadRight(7)}{fodder.GetSuit().PadLeft(2)} ]");
}

//DISPLAYS THE BOARDSTATE. SHOWS THE TOP CARD OF EVERY STACK AND ALL OF THE ROYAL COURT
public void DisplayBoard(Table table){
    Card fodder0 = table.GetFodder(0);
    Card fodder1 = table.GetFodder(1);
    Card fodder2 = table.GetFodder(2);
    Card fodder3 = table.GetFodder(3);
    Card fodder4 = table.GetFodder(4);
    Card fodder5 = table.GetFodder(5);
    Card fodder6 = table.GetFodder(6);
    Card fodder7 = table.GetFodder(7);
    Card fodder8 = table.GetFodder(8);

    Card royal0 = table.GetRoyal(0);
    Card royal1 = table.GetRoyal(1);
    Card royal2 = table.GetRoyal(2);
    Card royal3 = table.GetRoyal(3);
    Card royal4 = table.GetRoyal(4);
    Card royal5 = table.GetRoyal(5);
    Card royal6 = table.GetRoyal(6);
    Card royal7 = table.GetRoyal(7);
    Card royal8 = table.GetRoyal(8);
    Card royal9 = table.GetRoyal(9);
    Card royal10 = table.GetRoyal(10);
    Card royal11 = table.GetRoyal(11);

    Console.Write("            ");
    DisplayRoyal(royal0);
    DisplayRoyal(royal1);
    DisplayRoyal(royal2);
    Console.WriteLine();
    DisplayRoyal(royal3);
    DisplayFodder(fodder0);
    DisplayFodder(fodder1);
    DisplayFodder(fodder2);
    DisplayRoyal(royal4);
    Console.WriteLine();
    DisplayRoyal(royal5);
    DisplayFodder(fodder3);
    DisplayFodder(fodder4);
    DisplayFodder(fodder5);
    DisplayRoyal(royal6);
    Console.WriteLine();
    DisplayRoyal(royal7);
    DisplayFodder(fodder6);
    DisplayFodder(fodder7);
    DisplayFodder(fodder8);
    DisplayRoyal(royal8);
    Console.WriteLine();
    Console.Write("            ");
    DisplayRoyal(royal9);
    DisplayRoyal(royal10);
    DisplayRoyal(royal11);
    Console.WriteLine();
}

//TEST CODE THAT DISPLAYS EVERY CARD LEFT IN THE DECK. NOT IMPLEMENTED IN THE GAME
public void DisplayDeckContents(Deck deck){
    foreach (Card card in deck.GetDeckList()){
        DisplayFodder(card);
    }
}


}