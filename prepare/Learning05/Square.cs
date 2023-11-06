using System.Reflection.Metadata.Ecma335;

public class Square : Shape{

private int _side;

public Square(string color, int side) : base(color){
    _side = side;
    _color = color;
}



public override double GetArea(){
    double _area = _side*_side;
    return _area;
}
}