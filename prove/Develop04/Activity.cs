public class Activity
{
    private string _name {get; set;}
    private string _description {get; set;}
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
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.")
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

        int i = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write($"\r{i}\b");
            Thread.Sleep(1000); // Pause for 1 seconds
            i++;

        }

    }
}