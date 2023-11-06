using System.Formats.Asn1;

public class Circle : Shape{

private int _radius;

public Circle(string color, int radius) : base(color){
    _radius = radius;
    _color = color;
}



public override double GetArea(){
    double _area = Math.PI*_radius*_radius;
    return _area;
}
}