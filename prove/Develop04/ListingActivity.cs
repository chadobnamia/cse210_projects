using System.Runtime.CompilerServices;

public class ListingActivity:Activity
{
     private int _count;
     private List<string> _prompts;

     public ListingActivity(string name, string description):base(name, description)
     {
         _prompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
         };
        _count = 0;
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
        Console.WriteLine("List as many responses you can to the following prompt");
        GetRandomPrompt();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner(6);
        DisplayEndingMessage();
        ShowSpinner(3);
        
    }

    public void GetRandomPrompt()
    {
        var randPrompt = new Random();
        int index = randPrompt.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}---");
    }
    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        for (int i = 0; i<_duration;i++)
        {
            string item = Console.ReadLine();
            items.Add(item);
        }
        _count = items.Count();
        return items;
    }
    
 }