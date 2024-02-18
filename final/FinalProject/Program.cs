using System;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        // Interactive menu loop
        while (true)
        {
            Console.WriteLine("Task Manager Menu:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Complete");
            Console.WriteLine("3. Update Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Display All Tasks");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask(taskManager);
                    break;
                case "2":
                    MarkTaskAsComplete(taskManager);
                    break;
                case "3":
                    UpdateTask(taskManager);
                    break;
                case "4":
                    DeleteTask(taskManager);
                    break;
                case "5":
                    DisplayAllTasks(taskManager);
                    break;
                case "6":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }

            Console.WriteLine(); // Add a newline for better readability
        }
    }

    // Helper method to add a task based on user input
    static void AddTask(TaskManager taskManager)
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();

        Console.WriteLine("Choose task type:");
        Console.WriteLine("1. Regular Task");
        Console.WriteLine("2. Recurring Task");

        Console.Write("Enter your choice (1-2): ");
        string taskTypeChoice = Console.ReadLine();

        switch (taskTypeChoice)
        {
            case "1":
                taskManager.AddTask(new RegularTask(title));
                Console.WriteLine("Regular Task added successfully.");
                break;
            case "2":
                Console.Write("Enter task frequency: ");
                string frequency = Console.ReadLine();
                taskManager.AddTask(new RecurringTask(title, frequency));
                Console.WriteLine("Recurring Task added successfully.");
                break;
            default:
                Console.WriteLine("Invalid task type choice. Task not added.");
                break;
        }
    }

    // Helper method to mark a task as complete based on user input
    static void MarkTaskAsComplete(TaskManager taskManager)
    {
        Console.Write("Enter the index of the task to mark as complete: ");
        if (int.TryParse(Console.ReadLine(), out int taskIndex))
        {
            taskManager.MarkTaskAsComplete(taskIndex);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
    }

    // Helper method to display all tasks
    static void DisplayAllTasks(TaskManager taskManager)
    {
        taskManager.DisplayAllTasks();
    }

    static void UpdateTask(TaskManager taskManager)
    {
        Console.WriteLine("Select a task to update:");
        DisplayAllTasks(taskManager);

        Console.Write("Enter the index of the task to update: ");
        if (int.TryParse(Console.ReadLine(), out int taskIndex))
        {
            if (taskIndex >= 0 && taskIndex < taskManager.GetTaskCount())
            {
                Task taskToUpdate = taskManager.GetTaskByIndex(taskIndex);
                taskToUpdate.UpdateTaskDetails();
                Console.WriteLine("Task updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task index. Task not updated.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
    }

    // Helper method to delete a task based on user input
    static void DeleteTask(TaskManager taskManager)
    {
        Console.WriteLine("Select a task to delete:");
        DisplayAllTasks(taskManager);

        Console.Write("Enter the index of the task to delete: ");
        if (int.TryParse(Console.ReadLine(), out int taskIndex))
        {
            if (taskIndex >= 0 && taskIndex < taskManager.GetTaskCount())
            {
                taskManager.DeleteTask(taskIndex);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task index. Task not deleted.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
}
}