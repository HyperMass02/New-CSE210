public class Journal
{
    public string title;
    public string journal;
    public DateTime date;
    public string prompt;

    public void Display()
    {
        Console.WriteLine($"\nDate: {date}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Entry: {journal}");
        Console.WriteLine("------------------------------");
    }

    public string ToTextBlock()
    {
        return $"Date: {date}\nTitle: {title}\nPrompt: {prompt}\nEntry: {journal}\n------------------------------";
    }
}
