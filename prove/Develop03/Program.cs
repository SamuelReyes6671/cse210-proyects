using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Reference book=new Reference("Proverbs",3,5,6);

        Scripture scripture=new Scripture(book,"Trust in Jehovah with all your heart, and do not lean on your own prudence.");

        int numberToHide=3;

        scripture.HideRandomWords(numberToHide);

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Display Text");

        
    
    
    
    }
}
