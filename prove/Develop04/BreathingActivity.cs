public class BreathingActivity:Activity
{
    public BreathingActivity(string name, string description, int duration):base(name, description,duration)
    {}
    public void Run(int duration)
    {
        Console.WriteLine("Get ready...");

        for(int i = 0; i < duration; i+=2)
        {
        
        Console.WriteLine("Breathe in...");
        ShowSpinner(2);
        Console.WriteLine("Breathe out...");
        ShowSpinner(2);
        }
        
    }
}