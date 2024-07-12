public class Word
{
    private string _text;
    private bool _isHidden;
    private bool _isHintShown;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        _isHintShown = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void ShowFirstLetter()
    {
        _isHintShown = true;
    }

    public string GetDisplayText()
    {
        if (_isHintShown)
        {
            return _text[0] + new string('_', _text.Length - 1);
        }
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}