public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verseStart;
    private string _verseEnd;
    private string _referenceText;

    public Reference(string reference)
    {
        _referenceText = reference;
        string[] refArray = reference.Split(' ', ':', '-');
        _book = refArray[0];
        _chapter = refArray[1];
        _verse = refArray[2];
    }

    public Reference(string startReference, string endReference)
    {
        _referenceText = $"{startReference}-{endReference}";
        string[] refArray = startReference.Split(' ', ':');
        _book = refArray[0];
        _chapter = refArray[1];
        _verseStart = refArray[2];
        _verseEnd = endReference;
    }

    public string GetReference()
    {
        return _referenceText;
    }
}