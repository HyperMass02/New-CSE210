using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection()
        : base("Let's begin!", "Reflection", 0, "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different?",
            "What is your favorite thing about this experience?",
            "What could you learn from this?",
            "What did you learn about yourself?",
            "How can you remember this in the future?"
        };
    }

    public void DisplayReflection()
    {
        DisplayStartMessage();

        Random rand = new Random();
        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Pause(5, 3); // dots to think

        int timeRemaining = GetActivityDuration();

        while (timeRemaining > 0)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            Pause(5, 1); // spinner while reflecting
            timeRemaining -= 5;
        }

        DisplayEndMessage();
    }
}
