
class Reference
{
    // Attributes
    private string _book;
    private string _chapter;
    private string _verse;

    // Display
    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_verse}");
    }

    public void SetReference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
}