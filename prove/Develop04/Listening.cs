using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private List<string> _prompts;
    private List<string> _responses;

    public Listing()
        : base("Let's begin!", "Listing", 0, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _responses = new List<string>();
    }

    public void DisplayListing()
    {
        DisplayStartMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine(prompt);
        Console.WriteLine("\nYou will have a few seconds to think before listing starts...");
        Pause(3, 3); 

        Console.WriteLine("Start listing items. Press Enter after each one!");

        int seconds = GetActivityDuration();

        for (int i = 0; i < seconds; i++)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                _responses.Add(input);
            }
            Thread.Sleep(500);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_responses.Count} item(s).");
        DisplayEndMessage();
    }
}
