using System;
using System.Data;
using System.Net.Quic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Reference book=new Reference("Proverbs",3,5, 6);
        Scripture scripture=new Scripture(book ,"Trust in Jehovah with all your heart, and do not lean on your own prudence.");
        int numberToHide=1;
        Console.Write(book.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        scripture.HideRandomWords(numberToHide);

       while (true)
        {
            Console.WriteLine("Please press Enter to continue or type 'quite' to finish: ");
            string input = Console.ReadLine();

            if (input == "quite")
            {
                break;
            }
            scripture.HideRandomWords(numberToHide);
            Console.Write(book.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
        }
        
    }
}
