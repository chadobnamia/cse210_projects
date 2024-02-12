using System.Globalization;

public class BreathingActivity:Activity
{
    public BreathingActivity( string name, string description):base(name, description)
    {

    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        _duration  = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        for(int i = 0; i < _duration; i+=2)
        {   
            Console.WriteLine();
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine("Now Breathe out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
        ShowSpinner(2);
        
    }
}