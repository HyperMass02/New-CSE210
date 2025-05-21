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

    public static Journal FromTextBlock(string[] lines)
    {
        return new Journal
        {
            date = DateTime.Parse(lines[0].Substring(6)),
            title = lines[1].Substring(7),
            prompt = lines[2].Substring(8),
            journal = lines[3].Substring(7)
        };
    }
}
