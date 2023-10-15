public class SimpleGoal : Goal
{
    private bool _isCompleted = false;


    public SimpleGoal (string name, string description, int points, int bonus, bool isCompleted) : base(name, description, points, bonus)
    {
        _isCompleted = isCompleted;
    }

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public override void RecordEvent()
    {
        _checkbox = "[x]";
        _isCompleted = true;
    }

    public override bool IsComplete()
    {
        if (_isCompleted == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetGoalName()},{GetGoalDescription()},{GetPoints()},{GetBonus()},{_isCompleted}";
    }





}