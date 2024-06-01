using System.Diagnostics.CodeAnalysis;

public class Persona{

    private string nombre;
    private string id;
    private string pais;

    //public string Pais { get => pais; set => pais = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Id { get => id; set => id = value; }

    public string Pais
    {
        get {return "Mi pais es : "+pais;}
        set {pais =value;}
    }
}
