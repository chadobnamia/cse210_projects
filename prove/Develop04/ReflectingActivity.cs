using System.Data;

public class ReflectingActivity:Activity
{
    public List<string> _prompts = new List<string>
    {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
    };
    public List<string> _questions = new List<string>
    {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description):base(name, description)
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
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to your experience");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestion();
        ShowSpinner(6);
        DisplayQuestion();
        ShowSpinner(6);
        DisplayEndingMessage();
        ShowSpinner(3);

    }
    public string GetRandomPrompt()
    {
        var randPrompt = new Random();
        int index = randPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        var randQuestion = new Random();
        int index = randQuestion.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"\n---{GetRandomPrompt()}---");
    }
    public void DisplayQuestion()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }
}