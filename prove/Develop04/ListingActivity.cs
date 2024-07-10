using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class ListingActivity
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Starting Listing Activity");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.Write("Enter the duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(5);
            Random random = new Random();
            Console.WriteLine(prompts[random.Next(prompts.Count)]);
            ShowSpinner(5);
            Console.WriteLine("Start listing items...");
            int itemCount = 0;
            for (int i = 0; i < duration / 5; i++)
            {
                Console.Write("> ");
                Console.ReadLine();
                itemCount++;
                ShowSpinner(5);
            }
            Console.WriteLine($"You listed {itemCount} items.");
            Console.WriteLine($"Good job! You have completed the Listing Activity for {duration} seconds.");
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

