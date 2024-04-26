using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWellcome();

        string user=PromptUserName();

        int Number=PromptUserNumber();

        int squareNumber=SquareNumber(Number);

        DisplayResult(user,squareNumber);
    }

    static void DisplayWellcome()
    {
        Console.Write("Welcome to the program!");
    }
    static string PromptUserName( )
    {
        Console.WriteLine("Please enter your name: ");
        string name=Console.ReadLine();
        return name;
    }
    static int PromptUserNumber ()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number= int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number*number;
        return square;
    }
    static void DisplayResult(string name , int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}