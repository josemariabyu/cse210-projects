using System;

public class Word
{
    public string Text { get; private set; }
    private bool _isHidden;

    public Word(string text)
    {
        Text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string Display()
    {
        return _isHidden ? new string('_', Text.Length) : Text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}
