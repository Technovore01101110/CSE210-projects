
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

    public void AddComment(string nameP, string commentP)
    {
        Comment comment = new Comment(nameP, commentP);
        _comments.Add(comment);
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetTimeLength()
    {
        return _timeLength;
    }

    public int TotalComments()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {   
        foreach (Comment currentComment in _comments)
        {
            currentComment.DisplayComment();
            Console.WriteLine();
        }
    }
}