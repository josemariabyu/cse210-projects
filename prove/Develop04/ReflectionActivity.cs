using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class ReflectionActivity
    {
        private List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Starting Reflection Activity");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.Write("Enter the duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(5);
            Random random = new Random();
            Console.WriteLine(prompts[random.Next(prompts.Count)]);
            for (int i = 0; i < duration / 10; i++)
            {
                Console.WriteLine(questions[random.Next(questions.Count)]);
                ShowSpinner(10);
            }
            Console.WriteLine($"Good job! You have completed the Reflection Activity for {duration} seconds.");
            ShowSpinner(3);
        }

        private void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("/");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b-");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b\\");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b|");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b");
            }
            Console.WriteLine();
        }
    }
}

