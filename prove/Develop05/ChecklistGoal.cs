public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        currentCount++;
        if (currentCount >= targetCount)
        {
            isComplete = true;
        }
    }

    public override string GetDetailsString()
    {
        return $"Checklist Goal: {name} - Points: {points} - Complete: {isComplete} - Progress: {currentCount}/{targetCount}";
    }

    public int GetBonusPoints()
    {
        return isComplete ? bonusPoints : 0;
    }

    public override void Display()
    {
        string status = isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {name} - Progress: {currentCount}/{targetCount}");
    }
}
