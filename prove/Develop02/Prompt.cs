using System;

public static class Prompt
{
    private static string[] prompts = new string[]
    {
        "What was the highlight of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you handled it.",
        "What made you smile today?",
        "What is something new you learned today?",
        "How are you feeling right now?",
        "If you could relive one moment from today, what would it be and why?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I want to remember about today?",
        "What is something I want to improve on tomorrow?",
        "What is something I want to let go of?",
        "What is something I want to accomplish tomorrow?",
        "What is something I want to learn more about?",
        "What is something I want to do for someone else?",
        "What is something I want to do for myself?",
        "What is something I want to do for my community?",
    };

    public static string DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}