
class Video
{
    private string _title;
    private string _author;
    private string _description;
    private int _timeLength;
    private List<Comment> _comments = new List<Comment>();

    public Video(string titleP, string authorP, string descriptionP,
                 int timeLengthP)
    {
        _title = titleP;
        _author = authorP;
        _description = descriptionP;
        _timeLength = timeLengthP;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"By \"{_author}\"");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Video Length: {_timeLength} seconds");
    }

    public void AddComment(string nameP, string commentP)
    {
        Comment comment = new Comment(nameP, commentP);
        _comments.Add(comment);
    }

    public int TotalComments()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"\n{TotalComments()} Comments:\n");
        
        foreach (Comment currentComment in _comments)
        {
            currentComment.DisplayComment();
            Console.WriteLine();
        }
    }
}