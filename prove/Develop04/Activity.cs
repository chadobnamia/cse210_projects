public class Activity
{
    public string _name {get; set;}
    public string _description {get; set;}
    public int _duration {get;set;}

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine($"\n{_description}");

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"\nYou have completed {_duration} seconds of {_name}.");
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
            {
                Console.Write("/\b");
                Thread.Sleep(300); // Pause for 0.1 seconds
                Console.Write("|\b");
                Thread.Sleep(300); // Pause for 0.1 seconds
                Console.Write("\\\b");
                Thread.Sleep(300); // Pause for 0.1 seconds
                Console.Write("-\b");
                Thread.Sleep(300); // Pause for 0.1 seconds
            }
    }
    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while(DateTime.Now < endTime)
        {
            Console.Write($"\r{seconds}\b");
            Thread.Sleep(1000); // Pause for 1 seconds
            seconds--;

        }

    }
}