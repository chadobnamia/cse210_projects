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
        DisplayPlayerInfo();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.name);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(string name, string description, int points, int target = 0, int bonus = 0)
    {
        Goal newGoal;
        if (target == 0)
            newGoal = new SimpleGoal(name, description, points);
        else
            newGoal = new ChecklistGoal(name, description, points, target, bonus);

        _goals.Add(newGoal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal._shortName == goalName)
            {
                goal.RecordEvent();
                _score += goal._points;
                Console.WriteLine($"Event recorded for {goalName}");
                return;
            }
        }
        Console.WriteLine($"Goal {goalName} not found.");
    }

    public void SaveGoals()
    {
        // Implement saving goals to a file
    }

    public void LoadGoals()
    {
        // Implement loading goals from a file
    }
}