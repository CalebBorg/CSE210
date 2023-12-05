using System.Net.Security;

public class Card{

string _suit;
int _value;
bool _isRoyal;
bool _isAce = false;
int _armor = 0;

public Card(string suit, int value){
    _suit = suit;
    _value = value;
}

//RETURNS THE SUIT OF A CARD
public string GetSuit(){
    return _suit;
}

//RETURNS THE VALUE OF A CARD
public int GetValue(){
    return _value;
}

//RETURNS "fodder", BUT FOR ROYAL CARDS RETURNS THEIR FACE
public virtual string GetFace(){
    return "fodder";
}

//DOES NOTHING FOR MOST CARDS, BUT FOR ACES IT TAKES THE STACK THEY'RE PLACED ON TOP OF AND PUTS THEM ON THE BOTTOM OF THE DECK
public virtual void ConscriptStack(int location, Deck deck, Stack stack, Card draw){

}

//RETURNS 0 UNLESS THE CARD IS A ROYAL THAT HAS ARMOR
public virtual int GetArmor(){
    return 0;
}

//DOES NOTHING UNLESS THE CARD IS A ROYAL, THEN IT ADDS ARMOR TO THAT ROYAL EQUAL TO armorIncrease
public virtual void SetArmor(int armorIncrease){
}

//RETURNS THE COLOR OF ANY CARD BASED ON ITS SUIT
public string GetColor(){
    if (_suit == "♦" || _suit == "♥"){
        return "red";
    }
    else{
        return "black";
    }
}

//CHECKS IF THE CARD IS AN ACE. FOR ACES THIS RETURNS true
public virtual bool CheckIfAce(){
    return false;
}

}