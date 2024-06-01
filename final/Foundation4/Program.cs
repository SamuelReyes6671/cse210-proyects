using System;
using System.Threading.Tasks.Dataflow;
using System.IO;

class Program|
{
    static void Main(string[] args)
    {
        TextReader Leer=new StreamReader("Notas.txt");
        Leer.ReadToEnd();
        Leer.Close();   


        }

    
}