public class RegularTask : Task
{
    public RegularTask(string title) : base(title)
    {
    }

    // Implementing abstract method to display task details
    public override void DisplayTaskDetails()
    {
        Console.WriteLine($"[Regular Task] Title: {Title}, Completed: {IsCompleted}");
    }

    // Implementing abstract method to update task details
    public override void UpdateTaskDetails()
    {
        Console.Write("Enter new title for the regular task: ");
        Title = Console.ReadLine();
    }
}