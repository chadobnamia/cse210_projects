public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
     { }

    // Overrides
    public override void RecordEvent()
    {
        // Implement as needed
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {_shortName},{_description},{_points}";
    }
}