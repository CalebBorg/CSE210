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

public string GetSuit(){
    return _suit;
}

public int GetValue(){
    return _value;
}

public virtual string GetFace(){
    return "fodder";
}

public virtual void ConscriptStack(int location, Deck deck, Stack stack){

}

public virtual int GetArmor(){
    return 0;
}

public virtual void SetArmor(int armorIncrease){
}

public string GetColor(){
    if (_suit == "◆" || _suit == "♥"){
        return "red";
    }
    else{
        return "black";
    }
}

public virtual bool CheckIfAce(){
    return false;
}

}