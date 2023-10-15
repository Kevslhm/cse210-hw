public class EternalGoal : Goal
{


    public EternalGoal(string name, string description, int points, int bonus) : base(name, description, points, bonus)
    {
        
    }

    public override void RecordEvent()
    {
        _checkbox = "[ ]";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetGoalName()},{GetGoalDescription()},{GetBonus()},{GetPoints()}";
    }
}