using System;

public abstract class Goal
{
    public string Name { get; }
    public int Value { get; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        IsCompleted = false;
    }

    
    public abstract void RecordEvent();
}

