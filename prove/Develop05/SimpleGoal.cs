public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description)
    {
        Points = points;
    }

    public override void RecordEvent()
    {
        // No es necesario registrar eventos para metas simples
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}: {Description} ({Points} puntos)";
    }
}
