public class Ace : Card{

string _suit;
int _value;

public Ace(string suit, int value) : base(suit, value){
    _suit = suit;
    _value = value;
}

//ADD A STACK ONTO THE BOTTOM OF THE DECK IN ORDER
public override void ConscriptStack(int location, Deck deck, Stack stack, Card draw){
    List<Card> stackList = stack.GetAll();
    deck.AddCards(stackList);
    stack.ClearStack();
}

//CHECK IF A CARD IS AN ACE
public override bool CheckIfAce(){
    return true;
}

}