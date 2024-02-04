using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu:");
        string choice = Console.ReadLine();


        switch(choice)
        {
            case "1":
                Activity newActivity = new Activity("breathing","this",2);
                newActivity.run(2);
            break;

            case "2":

            break;

            case "3":

            break;

            case "4":
            return;

        }
    }
}