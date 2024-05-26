public class EternalGoal : Goal
{
    public int Points { get; set; }

    public EternalGoal(string shortName, string description, int points) : base(shortName, description)
    {
        Points = points;
    }

    public override void RecordEvent()
    {
        // Eternal goals are never marked complete, so no action needed
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}: {Description} ({Points} points)";
    }
}
