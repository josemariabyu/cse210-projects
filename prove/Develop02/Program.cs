using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}

class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private static readonly string[] _prompts = 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry(prompt, response, date);
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void LoadJournal(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2], parts[0]);
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveJournal(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadJournal(loadFilename);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

