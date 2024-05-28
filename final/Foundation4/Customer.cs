public class Customer{
    private string  _nombre;
    private string _edad;
    private string _direccion;
    private string _pais;

    public Customer(string nombre, string edad , string direccion, string pais ){
        _nombre = nombre;
        _edad = edad;
        _direccion = direccion;
        _pais=pais;
    }
    public void Llamar(){
        Console.WriteLine("Mi nombre es: "+ _nombre+" tengo "+_edad+" vivo en "+_direccion+" y soy de "+ _pais);
    }


}