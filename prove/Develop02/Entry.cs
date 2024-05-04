using System;
using System.Security.Cryptography.X509Certificates;

public class Entry(string date)
{

    public string _date;
    public string _prompText;
    public string _entryText;

    public Entry(string date, string prompText, string entryText) : this(date)
    {
        _date = date;
        _prompText = prompText;
        _entryText = entryText;
    }

    public void Display(){

        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Prompt: {_prompText}");
        Console.WriteLine($"Entry: {_entryText}");
        
    }
}