using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address
        {
            _street = "123 Main St",
            _city = "New York",
            _state = "NY",
            _zipCode = "10001"
        };

        Event lecture = new Lecture("Art of Public Speaking", "Learn how to captivate an audience", new DateTime(2024, 3, 15), new TimeSpan(13, 0, 0), address, "John Doe", 50);
        Event reception = new Reception("Networking Mixer", "Network with industry professionals", new DateTime(2024, 4, 20), new TimeSpan(18, 0, 0), address, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy food and games in the outdoors", new DateTime(2024, 5, 25), new TimeSpan(12, 0, 0), address, "Sunny with a high of 75°F");

        Console.WriteLine("Lecture Marketing Messages:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Reception Marketing Messages:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Marketing Messages:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}