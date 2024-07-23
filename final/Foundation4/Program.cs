using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of different activities
        Activity running = new Running("2024-07-23", 30, 5.0);
        Activity cycling = new Cycling("2024-07-24", 45, 20.0);
        Activity swimming = new Swimming("2024-07-25", 60, 40);

        // Put activities in a list
        Activity[] activities = { running, cycling, swimming };

        // Iterate through the list of activities and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('-', 40));
        }
    }
}
public class Activity
{
    public string Date { get; set; }
    public int Length { get; set; } // Length in minutes

    public Activity(string date, int length)
    {
        Date = date;
        Length = length;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"Date: {Date}, Length: {Length} minutes, Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
}
public class Running : Activity
{
    public double Distance { get; set; } // Distance in kilometers

    public Running(string date, int length, double distance) : base(date, length)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Length) * 60;
    }

    public override double GetPace()
    {
        return Length / Distance;
    }

    public override string GetSummary()
    {
        return $"Running - {base.GetSummary()}";
    }
}
public class Cycling : Activity
{
    public double Speed { get; set; } // Speed in km/h

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * (Length / 60.0);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"Cycling - {base.GetSummary()}";
    }
}
public class Swimming : Activity
{
    public int Laps { get; set; }
    private const double LapDistance = 0.05; // Assuming each lap is 50 meters

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * LapDistance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Length) * 60;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"Swimming - {base.GetSummary()}";
    }
}
