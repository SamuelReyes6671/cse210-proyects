public class ChecklistGoal : Goal
{
    public int Target { get; set; }
    public int Bonus { get; set; }
    private int _amountCompleted;

    public ChecklistGoal(string shortName, string description, int target, int bonus) : base(shortName, description)
    {
        Target = target;
        Bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}: {Description} (Completed {_amountCompleted}/{Target} times)";
    }
}
