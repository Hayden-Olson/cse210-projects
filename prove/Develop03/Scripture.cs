public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _ref;

    public Scripture(Reference reference, string words)
    {
        _ref = reference;
    
        string[] parts = words.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public bool IsAllHidden()
    {
        bool allHidden = true;
        foreach (Word word in _words)
        {
            word.IsHidden();
            
            if (word.IsHidden() == false)
            {
                allHidden = false;
            }
        }
        return allHidden;
    }

    public void HideWords()
    {
        Random random = new Random();
        Word word1 = _words[random.Next(0, _words.Count())];
        word1.Hide();
        Word word2 = _words[random.Next(0, _words.Count())];
        word2.Hide();
        Word word3 = _words[random.Next(0, _words.Count())];
        word3.Hide();
    }

    public void Display()
    {
        Console.Write(_ref.GetDisplayContent());

        foreach (Word word in _words)
        {
            Console.Write(" " + word.GetDisplayContent());
        }
        Console.WriteLine();
    }
}