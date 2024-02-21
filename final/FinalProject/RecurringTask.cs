public class RecurringTask : Task
{
    public string Frequency { get; set; }

    // Constructor
    public RecurringTask(string title, string frequency) : base(title)
    {
        Frequency = frequency;
    }

    // Implementing abstract method to display task details
    public override void DisplayTaskDetails()
    {
        Console.WriteLine($"[Recurring Task] Title: {Title}, Frequency: {Frequency}, Status: {TaskStatus.Status}");
    }

    // Implementing abstract method to update task details
    public override void UpdateTaskDetails()
    {
        Console.Write("Enter new title for the recurring task: ");
        Title = Console.ReadLine();
        Console.Write("Enter new frequency: ");
        Frequency = Console.ReadLine();
    }
}