public class Shape
{
    private string _color;


    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double _GetArea()
    {
        double _area = 5;
        return _area;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"This is the color: {_color} and this the area: {_GetArea()}");
    }
}