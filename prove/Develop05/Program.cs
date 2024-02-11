using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int choice;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a new Simple Goal");
            Console.WriteLine("2. Create a new Eternal Goal");
            Console.WriteLine("3. Create a new Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Goals Status");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the name of the Simple Goal: ");
                        string simpleGoalName = Console.ReadLine();
                        goals.Add(new SimpleGoal(simpleGoalName, 1000));
                        break;

                    case 2:
                        Console.Write("Enter the name of the Eternal Goal: ");
                        string eternalGoalName = Console.ReadLine();
                        goals.Add(new EternalGoal(eternalGoalName, 100));
                        break;

                    case 3:
                        Console.Write("Enter the name of the Checklist Goal: ");
                        string checklistGoalName = Console.ReadLine();
                        Console.Write("Enter the target count for the Checklist Goal: ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            goals.Add(new ChecklistGoal(checklistGoalName, 50, targetCount));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for target count. Please enter a valid number.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nSelect a goal to record an event:");
                        for (int i = 0; i < goals.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {goals[i].Name}");
                        }

                        Console.Write("Enter the goal number: ");
                        if (int.TryParse(Console.ReadLine(), out int recordEventIndex) && recordEventIndex > 0 && recordEventIndex <= goals.Count)
                        {
                            goals[recordEventIndex - 1].RecordEvent();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid goal number.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nGoals Status:");
                        for (int i = 0; i < goals.Count; i++)
                        {
                            goals[i].DisplayStatus();
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (choice != 6);
    }
}