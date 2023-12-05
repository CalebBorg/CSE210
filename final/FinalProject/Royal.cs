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

//RETURN THE FACE OF THE ROYAL
public override string GetFace(){
    return _face;
}

//RETURN THE ARMOR OF THE ROYAL
public override int GetArmor(){
    return _armor;
}

//INCREASE A ROYAL'S ARMOR
public override void SetArmor(int armorIncrease){
    _armor = _armor + armorIncrease;
}

}
