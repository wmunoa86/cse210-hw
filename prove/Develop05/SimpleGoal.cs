public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Completed = true;
        Console.WriteLine($"{Name} completed! You earned {Points} points.");
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[ {(Completed ? "X" : " ")} ] {Name}");
    }
}