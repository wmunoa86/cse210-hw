public class DeleteTask : Task
{
    public DeleteTask(string title) : base(title)
    {
    }

    // Implementing abstract method to display task details
    public override void DisplayTaskDetails()
    {
        Console.WriteLine($"[Delete Task] Title: {Title}, Status: {TaskStatus.Status}");
    }

    // Implementing abstract method to update task details (not applicable for deleting tasks)
    public override void UpdateTaskDetails()
    {
        // No update operation for deleting tasks
    }
}