using System.Numerics;

public class Fraction{

private float _top;
private float _bottom;
private float _fraction;

public Fraction(){
    _top = 1;
    _bottom = 1;
    _fraction = _top/_bottom;
}

public Fraction(int _inputTop){
    _top = _inputTop;
    _bottom = 1;
    _fraction = _top/_bottom;
}

public Fraction(int _inputTop, int _inputBottom){
    _top = _inputTop;
    _bottom = _inputBottom;
    _fraction = _top/_bottom;
}

public string GetFractionString(){
    return ($"{_top}/{_bottom}");
}

public double GetDecimalValue(){
    double deci = (_top)/(_bottom);
    return deci;
}   

public float GetTop(){
    return _top;
}

public float GetBottom(){
    return _bottom;
}

public void SetTop(){
    _top = float.Parse(Console.ReadLine());
}

public void SetBottom(){
    _bottom = float.Parse(Console.ReadLine());
}


}