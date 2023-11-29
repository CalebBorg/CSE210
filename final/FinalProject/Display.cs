using System.Runtime.InteropServices;

public class Display{

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

public void DisplayFodder(Card fodder){
    Console.Write($"[{fodder.GetValue().ToString().PadRight(7)}{fodder.GetSuit().PadLeft(2)} ]");
}


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
    Console.WriteLine();


//   Console.WriteLine($"""
//[{royal0.GetSuit()},{royal0.GetValue()},{royal0.GetFace()},{royal0.GetArmor()}] [{royal1.GetSuit()},{royal1.GetValue()},{royal1.GetFace()},{royal1.GetArmor()}] [{royal2.GetSuit()},{royal2.GetValue()},{royal2.GetFace()},{royal2.GetArmor()}]
//[{royal3.GetSuit()},{royal3.GetValue()},{royal3.GetFace()},{royal3.GetArmor()}] [{fodder0.GetSuit()},{fodder0.GetValue()}] [{fodder1.GetSuit()},{fodder1.GetValue()}] [{fodder2.GetSuit()},{fodder2.GetValue()}] [{royal4.GetSuit()},{royal4.GetValue()},{royal4.GetFace()},{royal4.GetArmor()}]
//[{royal5.GetSuit()},{royal5.GetValue()},{royal5.GetFace()},{royal5.GetArmor()}] [{fodder3.GetSuit()},{fodder3.GetValue()}] [{fodder4.GetSuit()},{fodder4.GetValue()}] [{fodder5.GetSuit()},{fodder5.GetValue()}] [{royal6.GetSuit()},{royal6.GetValue()},{royal6.GetFace()},{royal6.GetArmor()}]
//[{royal7.GetSuit()},{royal7.GetValue()},{royal7.GetFace()},{royal7.GetArmor()}] [{fodder6.GetSuit()},{fodder6.GetValue()}] [{fodder7.GetSuit()},{fodder7.GetValue()}] [{fodder8.GetSuit()},{fodder8.GetValue()}] [{royal8.GetSuit()},{royal8.GetValue()},{royal8.GetFace()},{royal8.GetArmor()}]
//[{royal9.GetSuit()},{royal9.GetValue()},{royal9.GetFace()},{royal9.GetArmor()}] [{royal10.GetSuit()},{royal10.GetValue()},{royal10.GetFace()},{royal10.GetArmor()}] [{royal11.GetSuit()},{royal11.GetValue()},{royal11.GetFace()},{royal11.GetArmor()}]


//""");
}



}