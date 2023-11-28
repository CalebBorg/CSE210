public class Fodder : Card{

string _suit;
int _value;
int _armor = 0;

public Fodder(string suit, int value) : base(suit, value){
    _suit = suit;
    _value = value;
}



}