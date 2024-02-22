using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    public void Display()
    {   
            Console.WriteLine("Video Details:");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Number of comments: {_comments.Count}");
            Console.WriteLine();
            Console.WriteLine("Comments");
            int n =0;
            foreach(Comment comment in _comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine();

    }
}
