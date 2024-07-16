using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int userScore = 0;

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save and exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;
                case "2":
                    RecordEvent(goals, ref userScore);
                    break;
                case "3":
                    ShowGoals(goals);
                    break;
                case "4":
                    ShowScore(userScore);
                    break;
                case "5":
                    SaveProgress(goals, userScore);
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice, goal not created.");
                break;
        }
    }

    static void RecordEvent(List<Goal> goals, ref int userScore)
    {
        Console.WriteLine("Choose a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goals.Count)
        {
            Goal selectedGoal = goals[choice];
            selectedGoal.RecordEvent();
            userScore += selectedGoal.GetPoints();

            if (selectedGoal is ChecklistGoal checklistGoal)
            {
                userScore += checklistGoal.GetBonusPoints();
            }

            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void ShowGoals(List<Goal> goals)
    {
        foreach (Goal goal in goals)
        {
            goal.Display();
        }
    }

    static void ShowScore(int userScore)
    {
        Console.WriteLine($"Your score: {userScore}");
    }

    static void SaveProgress(List<Goal> goals, int userScore)
    {
        // Implement saving functionality here
        Console.WriteLine("Progress saved.");
    }
}
