public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description)
    {
        Points = points;
    }

    public override void RecordEvent()
    {
        // No need to record events for simple goals
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}: {Description} ({Points} points)";
    }
}