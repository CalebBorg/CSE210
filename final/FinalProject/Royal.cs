using System.Net.Security;

public class Royal : Card{

String _face;
string _suit;
int _value;
int _armor;


public Royal(string suit, int value,string face,  int armor) : base(suit, value){
    _face = face;
    _suit = suit;
    _value = value;
    _armor = armor;
}

public override string GetFace(){
    return _face;
}

public override int GetArmor(){
    return _armor;
}

public override void SetArmor(int armorIncrease){
    _armor = _armor + armorIncrease;
}

}
