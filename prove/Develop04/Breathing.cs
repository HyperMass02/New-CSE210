using System;

public class Breathing : Activity
{
    public Breathing() 
        : base("Let's begin!", "Breathing", 0, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void DisplayBreathing()
    {
        DisplayStartMessage();

        int timeRemaining = GetActivityDuration();

        while (timeRemaining > 0)
        {
            Console.WriteLine("Breathe in...");
            Pause(3, 2); // countdown numbers
            timeRemaining -= 3;

            if (timeRemaining <= 0) break;

            Console.WriteLine("Breathe out...");
            Pause(3, 2); // countdown numbers
            timeRemaining -= 3;
        }

        DisplayEndMessage();
    }
}
