
class Scripture
{
    // Attributes
    private Reference _reference = new Reference();
    private Verse _verse;
    private string _fileName = "scriptures.csv";

    // Constructors
    
    // This scripture constructor will get a random scripture if nothing is put
    // in as a parameter.
    public Scripture()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        Random random = new Random();
        int fileLength = lines.Length;
        int randomLine = random.Next(1, fileLength);

        string line = lines[randomLine];
        string[] parts = line.Split("|");
        _reference.SetReference(parts[0], parts[1], parts[2]);
        _verse = new Verse(parts[3]);
    }

    public Scripture(string book, string chapter, string verse_numb,
    string verse)
    {
        _reference.SetReference(book, chapter, verse_numb);
        _verse = new Verse(verse);
    }

    // Behaviors
    public void Display()
    {
        // This will clear the console and display the reference and scripture.
        Console.Clear();
        _reference.Display();
        _verse.Display();
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int WordsLeftLength = _verse.WordsLeft().Count();
        int max = 5;
        // If their are less five, this will change the random max to max words
        // left.
        if (WordsLeftLength < 5)
        {
            max = WordsLeftLength;
        }
        
        // This will hide a word each time it runs.
        for (int i = 0; i < random.Next(1, max); i++)
        {
            // This gets the indexes of the words that are still visible.
            List<int> revealedWordsIndexes = _verse.WordsLeft();

            // From the list, it will get a random index and call the word's
            // hide behavior.
            int randomWordIndex = revealedWordsIndexes[random.Next(0, revealedWordsIndexes.Count)];
            _verse.HideWord(randomWordIndex);
        }
    }

    // Getter
    public bool AnyWordsLeft()
    {
        return _verse.WordsLeft().Count != 0;
    }

}