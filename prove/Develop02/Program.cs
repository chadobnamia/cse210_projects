using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;
using Microsoft.Win32.SafeHandles;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Journal theJournal = new Journal();

        while(true)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            
            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();

        
            
            switch (choice)
            {

                case "1":

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    
                    PromptGenerator randPrompt  = new PromptGenerator();
                    string yourPrompt = randPrompt.GetRandomPrompt();
                    Console.WriteLine($"Your prompt: {yourPrompt}");
                    Console.WriteLine($"Journal entry: ");

                    Entry anEntry = new Entry
                    {
                        _entryText = Console.ReadLine(),
                        _promptText = yourPrompt,
                        _date = dateText
                    };

                    theJournal.AddEntry(anEntry);   
                break;

                case "2":
                    Console.WriteLine("All entries");
                    theJournal.DisplayAll();
                
                break;

                case "3":
                    theJournal.LoadFromFile("journal.txt");
                break;

                case "4":

                    theJournal.SaveToFile("journal.txt");

                break;

                case "5":
                    return;
            }
        }   
    }

    
}