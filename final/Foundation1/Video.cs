class Video
{
    private string _title, _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void SetComments(string name, string comment)
    {
        Comment c1 = new Comment(name, comment);
        comments.Add(c1);
    }
    public int GetCommentNumber()
    {
        return comments.Count();
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"{_title} by {_author} ({_length} seconds) Number of Comments: {GetCommentNumber()}");
        int index = 1;
        foreach (var comment in comments)
        {
            Console.WriteLine($"    {index}. {comment.GetCommentName()}: {comment.GetCommentText()}");
            index ++;
        }
    }
}