using System;
using System.IO;
class Program
{
    static void Main(string[] args)

    {   TextWriter Escribe = new StreamWriter("Test.txt");
        Escribe.WriteLine("Hola Mundo, mi nombre es Samuel ");
        Escribe.Close();
        
    
    }
}