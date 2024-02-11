public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    // Overrides
    public override void RecordEvent()
    {
        // Implement as needed
    }

    public override bool IsComplete()
    {
        // Implement as needed
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} - {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}