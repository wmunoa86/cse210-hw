public abstract class Task
{
    public string Title { get; set; }
    public TaskStatus TaskStatus { get; set; }

    // Constructor
    public Task(string title)
    {
        Title = title;
        TaskStatus = new TaskStatus(TaskStatusEnum.InProgress); // Default status is InProgress
    }

    // Abstract method for displaying task details
    public abstract void DisplayTaskDetails();

    // Abstract method for updating task details
    public abstract void UpdateTaskDetails();
}