public class ChecklistGoal : Goal
{
    private int completedCount;
    private int targetCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        this.targetCount = targetCount;
    }

    public override void RecordEvent()
    {
        completedCount++;
        if (completedCount == targetCount)
        {
            Completed = true;
            Console.WriteLine($"{Name} completed! You earned {Points} points, and a bonus of {Points * targetCount} points.");
        }
        else
        {
            Console.WriteLine($"{Name} recorded! You earned {Points} points. ({completedCount}/{targetCount} completed)");
        }
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[ {(Completed ? "X" : " ")} ] {Name} (Completed {completedCount}/{targetCount} times)");
    }
}