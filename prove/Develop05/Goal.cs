using System;
using System.Collections.Generic;
using System.IO;

// Base class for all types of goals
public abstract class Goal
{
    public string ShortName { get; set; }
    public string Description { get; set; }

    public Goal(string shortName, string description)
    {
        ShortName = shortName;
        Description = description;
    }

    // Method to record an event (achievement) for the goal
    public abstract void RecordEvent();

    // Method to get a string representation of the goal
    public abstract string GetStringRepresentation();
}