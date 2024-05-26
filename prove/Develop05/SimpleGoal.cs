public class SimpleGoal : Goal
{
    public int Points { get; set; }
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description)
    {
        Points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}: {Description} ({Points} points)";
    }
}