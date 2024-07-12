public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string referenceString)
    {
        var parts = referenceString.Split(' ');
        _book = parts[0];
        var chapterAndVerses = parts[1].Split(':');
        _chapter = int.Parse(chapterAndVerses[0]);
        var verses = chapterAndVerses[1].Split('-');
        _verse = int.Parse(verses[0]);
        _endVerse = verses.Length > 1 ? int.Parse(verses[1]) : -1;
    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}