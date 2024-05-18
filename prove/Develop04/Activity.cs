using System;
using System.Threading;

public abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration; // Duration in seconds

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {Name} activity.");
        Console.WriteLine(Description);
        Console.Write("Enter duration (in seconds): ");
        Duration = int.Parse(Console.ReadLine());
        PrepareToBegin();
        Execute();
        End();
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    protected void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected abstract void Execute();
}
