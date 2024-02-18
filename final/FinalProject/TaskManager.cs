public class TaskManager
{
    private List<Task> tasks;

    // Constructor
    public TaskManager()
    {
        tasks = new List<Task>();
    }

    // Method to add a task to the task manager
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    // Method to mark a task as complete
    public void MarkTaskAsComplete(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks[index].IsCompleted = true;
            Console.WriteLine("Task marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }

    // Method to display all tasks
    public void DisplayAllTasks()
    {
        Console.WriteLine("All Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            tasks[i].DisplayTaskDetails();
        }
    }

    // Method to get the count of tasks
    public int GetTaskCount()
    {
        return tasks.Count;
    }

    // Method to get a task by index
    public Task GetTaskByIndex(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            return tasks[index];
        }
        return null; // Invalid index
    }

    // Method to delete a task by index
    public void DeleteTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Task deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task index. Task not deleted.");
        }
    }
}