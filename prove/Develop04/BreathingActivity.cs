public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "relax by walking your through breathing in and out slowly.")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Breathe();
        Conclude();
    }

    private void Breathe()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Now breathe out...");
            Countdown();
            //PauseWithSpinner(2);
        }
    }
}