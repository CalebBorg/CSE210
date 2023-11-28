public class Ace : Card{

string _suit;
int _value;
bool _isAce = true;

public Ace(string suit, int value) : base(suit, value){
    _suit = suit;
    _value = value;
}


public override void ConscriptStack(int location, Deck deck, Stack stack){
//put a full stack back in to the deck

}

public override bool CheckIfAce(){
    return true;
}

}