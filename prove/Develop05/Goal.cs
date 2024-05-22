public abstract class Goal{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal (string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent(){}
    public bool IsComplete(){}
    public string GetDetailsString(){}
    public string GetStringRepresentation(){}

    }