public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description)
    {
        Points = points;
    }

    public override void RecordEvent()
    {
        // No need to record events for eternal goals
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}: {Description} ({Points} points)";
    }
}