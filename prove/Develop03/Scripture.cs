public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;
        _words = verseText
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(w => new Word(w))
            .ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.DisplayReference()} - {GetFormattedVerse()}");
    }

    public void HideWords(int count)
    {
        var unhiddenWords = _words.Where(w => !w.isVisible()).ToList();

        for (int i = 0; i < count && unhiddenWords.Count > 0; i++)
        {
            int index = _random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.isVisible());
    }

    private string GetFormattedVerse()
    {
        return string.Join(" ", _words.Select(w => w.DisplayWord()));
    }
}