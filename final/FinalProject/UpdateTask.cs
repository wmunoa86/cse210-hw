public class UpdateTask : Task
{
    public UpdateTask(string title) : base(title)
    {
    }

    // Implementing abstract method to display task details
    public override void DisplayTaskDetails()
    {
        Console.WriteLine($"[Update Task] Title: {Title}, Status: {TaskStatus.Status}");
    }

    // Implementing abstract method to update task details
    public override void UpdateTaskDetails()
    {
        Console.Write("Enter new title for the update task: ");
        Title = Console.ReadLine();

        Console.WriteLine("Choose task status:");
        Console.WriteLine("1. Completed");
        Console.WriteLine("2. In Progress");

        Console.Write("Enter your choice (1-2): ");
        string statusChoice = Console.ReadLine();

        switch (statusChoice)
        {
            case "1":
                TaskStatus.Status = TaskStatusEnum.Completed;
                Console.WriteLine("Task marked as completed.");
                break;
            case "2":
                TaskStatus.Status = TaskStatusEnum.InProgress;
                Console.WriteLine("Task marked as in progress.");
                break;
            default:
                Console.WriteLine("Invalid status choice. Task status not updated.");
                break;
        }
    }
}
