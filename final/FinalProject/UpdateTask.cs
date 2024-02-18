public class UpdateTask : Task
{
    public UpdateTask(string title) : base(title)
    {
    }

    // Implementing abstract method to display task details
    public override void DisplayTaskDetails()
    {
        Console.WriteLine($"[Update Task] Title: {Title}, Completed: {IsCompleted}");
    }

    // Implementing abstract method to update task details
    public override void UpdateTaskDetails()
    {
        Console.Write("Enter new title for the update task: ");
        Title = Console.ReadLine();
    }
}
