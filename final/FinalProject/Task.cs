public abstract class Task
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    // Constructor
    public Task(string title)
    {
        Title = title;
        IsCompleted = false;
    }

    // Abstract method for displaying task details
    public abstract void DisplayTaskDetails();

    // Abstract method for updating task details
    public abstract void UpdateTaskDetails();
}