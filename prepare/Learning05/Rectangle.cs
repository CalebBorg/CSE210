public class Rectangle : Shape{

private int _width;
private int _length;

public Rectangle(string color, int width, int length) : base(color){
    _length = length;
    _width = width;
    _color = color;
}



public override double GetArea(){
    double _area = _width*_length;
    return _area;
}
}