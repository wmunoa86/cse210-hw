// Enum for task status
public enum TaskStatusEnum
{
    Completed,
    InProgress
}

// Task status class
public class TaskStatus
{
    public TaskStatusEnum Status { get; set; }

    // Constructor
    public TaskStatus(TaskStatusEnum status)
    {
        Status = status;
    }

    // Method to display task status
    public void DisplayStatus()
    {
        Console.WriteLine($"Task Status: {Status}");
    }
}