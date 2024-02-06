using System;

class Program
{
    static void Main(string[] args)
    {

        List<string> text = new List<string>
        {
            "Trust", "in","Lord","with","all","your","heart","and","lean","not","on","your","own","understanding;","in","all","your","ways","acknowledge","him,","and","he","will","make","your","paths","straight."
        };

        Reference newReference = new Reference("Proverbs",3,5,6);
        Scripture newScripture = new Scripture(newReference,text);

        while(!newScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(newReference.GetDisplayText());
            Console.WriteLine(newScripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            int numberToHide = new Random().Next(0, 4);
            newScripture.HideRandomWords(numberToHide);
        }
    }
}