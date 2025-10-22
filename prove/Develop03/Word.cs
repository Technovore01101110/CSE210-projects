class Word
{
    // Attributes
    private string _word;
    private bool _revealed;

    // Constructors
    public Word(string w)
    {
        _word = w;
        _revealed = true;
    }

    // Behaviors
    
    // Setter
    public void Hide()
    {
        _word = new string('_', _word.Length);
        _revealed = false;
    }

    public void Display()
    {
        Console.Write(" " + _word);
    }
    
    // Getter
    public bool IsRevealed()
    {
        return _revealed;
    }
}