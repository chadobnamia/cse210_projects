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

    public ReflectingActivity():base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}
    public void Run()
    {
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

            


    }
    public string GetRandomPrompt()
    {
        Random newRand = new Random();
        string prompt = _prompts[newRand.Next(_prompts.Count)];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random newRand1 = new Random();
        string question = _questions[newRand1.Next(_questions.Count)];
        return question;
    }
    public void DisplayPrompt()
    {
        GetRandomPrompt();
    }
    public void DisplayQuestion()
    {
        GetRandomQuestion();
    }
}