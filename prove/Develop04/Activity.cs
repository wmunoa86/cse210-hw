public class Activity
{
    protected int duration;
    protected string activityName;
    protected string activityDescription;

    public Activity(string name, string description)
    {
        activityName = name;
        activityDescription = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Welcome to {activityName}!");
        Console.WriteLine($"This activity will help you {activityDescription}.");
        SetDuration();
        PrepareToBegin();
    }

    public virtual void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    public virtual void PrepareToBegin()
    {
        Console.WriteLine($"Get ready to begin {activityName.ToLower()}...");
        PauseWithSpinner(3);
    }

    public virtual void Conclude()
    {
        Console.WriteLine($"Good job! You have completed {activityName} for {duration} seconds.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }

    protected void Countdown(){
         for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
    }
}