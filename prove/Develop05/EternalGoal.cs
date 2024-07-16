public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals do not get marked as complete
    }

    public override string GetDetailsString()
    {
        return $"Eternal Goal: {name} - Points: {points}";
    }
}




