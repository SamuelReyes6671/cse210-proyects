public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description)
    {
        Points = points;
    }

    public override void RecordEvent()
    {
        // No es necesario registrar eventos para metas eternas
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}: {Description} ({Points} puntos)";
    }
}
