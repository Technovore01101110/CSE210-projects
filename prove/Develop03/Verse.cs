class Verse
{
    // Attributes
    private List<Word> _words = new List<Word>();

    // Constructors
    public Verse(string v)
    {
        string[] words = v.Split(' ');

        foreach (string w in words)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }

    // Behaviors

    // Getter
    public List<int> WordsLeft()
    {
        // This gets all of the words which attribute 'IsRevealed" equals true.
        List<int> iWords = new List<int>();
        
        foreach (Word word in _words)
        {
            if (word.IsRevealed())
            {
                iWords.Add(_words.IndexOf(word));
            }

        }
        return iWords;
    }

    public void HideWord(int index)
    {
        _words[index].Hide();
    }
    
    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
        }
    }
}