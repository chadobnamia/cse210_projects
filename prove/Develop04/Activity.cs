public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description,int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine(_description);

        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration  = Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {
        for (int i=0; i<seconds;i++)
        {
            Console.WriteLine(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {

    }
}