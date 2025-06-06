public class Entry
{

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