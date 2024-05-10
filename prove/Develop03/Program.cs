using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Reference book=new Reference("Proverbs",3,5,6);
        Scripture scripture=new Scripture(book,"Trust in Jehovah with all your heart, and do not lean on your own prudence.");
        int numberToHide=5;

        while(true)
        {
            scripture.HideRandomWords(numberToHide);
        Console.Write(book.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Please enter to continue or type ´quite´ to finish: ");

        string input=Console.ReadLine();
        if(input=="quite")
        {
            break;
        }
        
        }
        
    }
}
