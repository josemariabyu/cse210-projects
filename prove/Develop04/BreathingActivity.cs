using System;

namespace MindfulnessApp
{
    class BreathingActivity
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Starting Breathing Activity");
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.Write("Enter the duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(5);
            for (int i = 0; i < duration / 5; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowSpinner(2);
                Console.WriteLine("Breathe out...");
                ShowSpinner(3);
            }
            Console.WriteLine($"Good job! You have completed the Breathing Activity for {duration} seconds.");
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
