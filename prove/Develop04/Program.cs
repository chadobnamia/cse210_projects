using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start reflection Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                     BreathingActivity breathing = new BreathingActivity("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                     breathing.Run();
                     break;
                case "2":
                     ReflectingActivity reflect = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                     reflect.Run();
                     break;
                case "3":
                     ListingActivity list = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                     list.Run();
                     break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                // cdefault:
                //     Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                //     break;
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}