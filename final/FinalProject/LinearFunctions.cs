public abstract class LinearFunctions
{
    private string _name;
    private float _y;
    private float _x; 

    private float _m;


    public LinearFunctions(string name, float y, float x, float m)
    {
        _name = name;
        _y = y;
        _x = x;
        _m = m;

    }


    public LinearFunctions()
    {
        
    }

    public string GetName()
    {
        return _name;
    }

    public float GetY()
    {
        return _y;
    }

    public float GetX()
    {
        return _x;
    }

    public float GetM()
    {
        return _m;
    }


    public void SetY(float y)
    {
        _y = y;
    }

    public void SetX(float x)
    {
        _x = x;
    }

    public void SetM(float m)
    {
        _m = m;
    }


    public abstract void ValueTable(float mValue = 0, float nValue = 0, float aValue = 0, float bValue = 0, float cValue = 0, string operator1 = "", string operator2 = "");

    public  abstract void SetFunction(string function);

    public abstract string GetFunctionData();

    
    

}