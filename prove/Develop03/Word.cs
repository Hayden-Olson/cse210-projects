using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayContent()
    {
        if (_isHidden == true)
        {
            string letter = "";
            for (int i=0; i < _text.Length; i++)
            {
                letter += "_";
            }
            return letter;
        }
        return _text;
    }
}