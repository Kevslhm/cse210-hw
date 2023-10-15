public  abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _bonus;
    protected string _checkbox = "[ ]";



    public Goal (string name, string description, int points, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonus = bonus;
    }

    public string GetGoalName()
    {
        return _name;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetCheckbox()
    {
        return _checkbox;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public void SetCheckbox(string checkbox)
    {
        _checkbox = checkbox;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
    


    public virtual string GetDetailString()
    {
        
        return $"{_checkbox} {_name} ({_description})";
    }

    public abstract string GetStringRepresentation();
    
}