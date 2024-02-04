public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity() : base("Listing", "reflecton the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Start()
    {
        base.Start();
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine(prompt);
        ListItems();
        Conclude();
    }

    private void ListItems()
    {
        Console.WriteLine("Think about the prompt and start listing items:");
        int itemsCount = 0;
        while (duration > 0)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
                break;

            itemsCount++;
            duration--;
        }
        Console.WriteLine($"You listed {itemsCount} items.");
    }
}