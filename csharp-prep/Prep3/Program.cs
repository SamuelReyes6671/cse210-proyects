using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int numberMagic=int.Parse(Console.ReadLine());  

        Random randomGenerator=new Random();
        int number=randomGenerator.Next(1,101);

        int guess=-1;

        while(guess!=numberMagic)
        {   
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());   
       
            if (numberMagic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (numberMagic < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }   
                   
        }     
    }  
}