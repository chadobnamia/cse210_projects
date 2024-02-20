using System;

// Create a list to hold activities
List<Activity> activities = new List<Activity>
            {
                // Add sample activities
                new Running(new DateTime(2022, 11, 3), 30, 3.0),
                new Cycling(new DateTime(2022, 11, 3), 30, 6.0),
                new Swimming(new DateTime(2022, 11, 3), 30, 20)
            };

// Display summary for each activity
foreach (var activity in activities)
{
    Console.WriteLine(activity.GetSummary());
}
