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
            _length = 120 
            };
        video1.AddComment("Alice", "Great video!");
        video1.AddComment("Bob", "Thanks for sharing.");
        video1.AddComment("Charlie", "Very helpful.");

        Video video2 = new Video 
        { 
            _title = "Strawberry Milkshake Recipe", 
            _author = "Jane Smith", 
            _length = 180 };
        video2.AddComment("David", "I learned a lot from this.");
        video2.AddComment("Emily", "Could you make more videos like this");
        video2.AddComment("Frank", "Awesome content!");

        Video video3 = new Video 
        { 
            _title = "Pacing Guide: Learning C# Step by Step", 
            _author = "Jonah Ruse", 
            _length = 180 };
        video3.AddComment("Ron", "Wonderful!!.");
        video3.AddComment("Emily", "I need this.");
        video3.AddComment("Frank", "Awesome content!");

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos
        foreach (var video in videos)
        {
            video.Display();
            // List out all comments for the video
            foreach (var comment in video.GetAllComments())
            {
                Console.WriteLine($"- {comment._name}: {comment._commentText}");
            }
            Console.WriteLine(); // Add a blank line for better readability
         }
    }
}