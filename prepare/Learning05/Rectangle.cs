public class Rectangle : Shape
{
    private double _height;
    private double _length;


    public double GetHeight()
    {
        return _height;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetHeight(double height)
    {
        _height = height;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public override double _GetArea()
    {
        double _area = _height * _length;
        return _area;
    }
}