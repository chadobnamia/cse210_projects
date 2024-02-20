public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
  

        while(true)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            string choice = Console.ReadLine();

            switch(choice)
            {               
                case "1":
                CreateGoal();
                break;
                case "2":
                ListGoalDetails();
                break;
                case "3":
                Console.WriteLine("What is the filename of the goal file");
                string filepath = Console.ReadLine();
                SaveGoals(filepath);
                break;
                case "4":
                
                break;
                case "5":
                RecordEvent();
                break;
                case "6":
                    return;
                default:
                Start();
                break;
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        foreach(var goal in _goals)
        {
            if(goal.IsComplete())
            {
                int points = int.Parse(goal.RecordEvent());
                _score += points;
            };
        }
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {   
        
        foreach(var goal in _goals)
        {   
            int i = 1;
            Console.Write($"{i} {goal}");
            i++;
        };
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (var goal in _goals)
        {   
            Console.WriteLine($"{i}.  {goal.GetDetailsString()}");
            i++;
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        string choice2 = Console.ReadLine();
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());


        Goal newGoal;
        if (choice2 == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        } 
        else if (choice2 == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, description, points, amount, bonus);
        }

        _goals.Add(newGoal);
    }

    public void RecordEvent()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }
        Console.WriteLine("Which goal did you accomplish?");
        int goalNumber = int.Parse(Console.ReadLine()) -1;

        if (goalNumber >=0 && goalNumber< _goals.Count)
        {
            Goal goal = _goals[goalNumber];
            goal.RecordEvent();

        }
    }

    public void SaveGoals(string filepath)
    {
        Console.WriteLine("Saving to file....");
        using (StreamWriter outputFile = new StreamWriter(filepath))
        {
            foreach (Goal goal in _goals)
            {
                
                outputFile.WriteLine(goal.GetStringRepresentation());   
            }
        }
    }

    public void LoadGoals(string filepath)
    {
       Console.WriteLine("Reading from file...");
        string[] lines = System.IO.File.ReadAllLines(filepath);
         
         foreach (var line in lines)
        {   
            string[] parts = line.Split(",");

            string name = 

            Goal newGoal;
            newGoal._name = parts[1];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
    }
}