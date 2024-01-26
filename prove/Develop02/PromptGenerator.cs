using System.Xml;

public class PromptGenerator
{
     public List<string> _prompts = new List<string>{

        "What are you grateful for today?",
        "Who made you feel happy today?",
        "What is the most delicious food you have tasted?",
        "How was the weather today?",
        "How was you work today?",
     };


    public string GetRandomPrompt()
    {
        var rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];

    }
}