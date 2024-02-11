public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"{Name} recorded! You earned {Points} points.");
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[ ] {Name} (Eternal)");
    }
}