using System;

public abstract class Goal
{
    protected string name;
    protected int points;
    protected bool isComplete;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.isComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetDetailsString();

    public bool IsComplete()
    {
        return isComplete;
    }

    public int GetPoints()
    {
        return points;
    }

    public string GetName()
    {
        return name;
    }

    public virtual void Display()
    {
        string status = isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {name}");
    }
}
