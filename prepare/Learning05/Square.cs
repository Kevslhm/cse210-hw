public class Square : Shape
{
    private double _side;

    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public override double _GetArea()
    {
        double _area = _side * _side;
        return _area;
    }
}