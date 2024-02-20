using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void AddComment(string name, string commentText)
    {
        _comments.Add(new Comment { _name = name, _commentText = commentText });
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetAllComments()
    {
        return _comments;
    }
    public void Display()
    {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Number of comments: {GetNumberOfComments()}");


    }
}
