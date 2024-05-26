[Serializable]
public abstract class Goal
{
    public string ShortName { get; set; }
    public string Description { get; set; }
    public int Points { get; protected set; }

    public Goal(string shortName, string description)
    {
        ShortName = shortName;
        Description = description;
        Points = 0; // Inicializamos los puntos en 0
    }

    // Método abstracto para registrar un evento relacionado con la meta
    public abstract void RecordEvent();

    // Método abstracto para obtener una representación de cadena de la meta
    public abstract string GetStringRepresentation();
}
