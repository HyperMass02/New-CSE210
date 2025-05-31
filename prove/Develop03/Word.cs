public class Word
{
    private bool _isVisible;

    private string _word;

    public Word(string text)
    {
        this._word = text;
        this._isVisible = false;
    }

    public void Hide()
    {
        _isVisible = true;
    }

    public bool isVisible()
    {
        return _isVisible;
    }

    public string DisplayWord()
    {
        return _isVisible ? new string('_', _word.Length) : _word;
    }

}