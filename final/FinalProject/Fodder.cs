public class Fodder : Card{

string _suit;
int _value;

public Fodder(string suit, int value) : base(suit, value){
    _suit = suit;
    _value = value;
}
}