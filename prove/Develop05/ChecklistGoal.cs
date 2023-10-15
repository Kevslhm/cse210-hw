public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points, bonus)
    {
        _target = target;
        _amountCompleted = amountCompleted;
    }


    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            _checkbox = "[x]";
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailString()
    {
        return $"{_checkbox} {GetGoalName()} ({GetGoalDescription()}) -- Currently completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetGoalName()},{GetGoalDescription()},{GetPoints()},{GetBonus()},{_target},{_amountCompleted}";
    }
}