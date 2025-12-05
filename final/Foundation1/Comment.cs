class Comment
{
    private string _username;
    private string _commentText;

    public Comment(string usernameP, string commentTextP)
    {
        _username = usernameP;
        _commentText = commentTextP;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"\t{_username}");
        Console.WriteLine($"\t{_commentText}");
    }
}