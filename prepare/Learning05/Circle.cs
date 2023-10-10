public class Circle : Shape
{
    private double _radius;


    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }


    public override double _GetArea()
    {
        double _area = Math.PI * (_radius * _radius);
        return _area;
    }

}