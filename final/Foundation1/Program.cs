using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video { 
            _title = "Introduction to C#", 
            _author = "Jenny Mill", 
            _length = 120,
            _comments = new List<Comment>()
            {
                new Comment("Alice", "Great video!"),
                new Comment("Bob", "Thanks for sharing."),
                new Comment("Charlie", "Very helpful."),
            }
        };
  
        Video video2 = new Video 
        { 
            _title = "Strawberry Milkshake Recipe", 
            _author = "Jane Smith", 
            _length = 180,
            _comments = new List<Comment>()
            {
                new Comment("David", "I learned a lot from this."),
                new Comment("Emily", "Could you make more videos like this"),
                new Comment("Frank", "Awesome content!"),
            }
        };

        Video video3 = new Video 
        { 
            _title = "Pacing Guide: Learning C# Step by Step", 
            _author = "Jonah Ruse", 
            _length = 180,
            _comments = new List<Comment>()
            {
                new Comment("Ron", "Wonderful!!."),
                new Comment("Emily", "I need this."),
                new Comment("Frank", "Awesome content!"),
            }
             };

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.Display();
        }
    }
}