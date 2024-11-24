public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string Text
    {
        get { return _word; }
    }

    public bool IsHidden
    {
        get { return _isHidden; }
    }
}