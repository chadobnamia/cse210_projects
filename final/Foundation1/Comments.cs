public class Comment
{
    public string _name;
    public string _commentText;
    public List<Video> _videos = new List<Video>();
    public Comment(string name, string comment)
    {
        _name = name;
        _commentText = comment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_commentText}");
    }
}
