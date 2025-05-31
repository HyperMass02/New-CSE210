using System.Data;

public class Reference
{
    private string _book;
    private string _chapter;

    private int _startVerse;
    private int _endVerse;
    public Reference(string book, string chapter, int start)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = -1;

        Console.WriteLine($"{_book} {_chapter}:{_startVerse}");

    }

    public Reference(string book, string chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;

    }
    public string DisplayReference()
    {
        return _endVerse == -1
            ? $"{_book} {_chapter}:{_startVerse}"
            : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}