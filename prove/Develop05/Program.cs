using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine($"You have {_points} ")
        GoalManager manager = new GoalManager();
        manager.CreateGoal("Run a marathon", "Complete a marathon race", 1000);
        manager.CreateGoal("Read scriptures", "Read scriptures daily", 100);
        manager.CreateGoal("Attend the temple", "Attend the temple regularly", 50, 10, 500);
        manager.Start();
    }
}