public abstract class Goal
{
    public string ShortName { get; set; }
    public string Description { get; set; }
    public int Points { get; protected set; }

    public Goal(string shortName, string description)
    {
        ShortName = shortName;
        Description = description;
        Points = 0; // Initialize points to 0
    }

    // Abstract method to record an event related to the goal
    public abstract void RecordEvent();

    // Abstract method to get a string representation of the goal
    public abstract string GetStringRepresentation();
}
