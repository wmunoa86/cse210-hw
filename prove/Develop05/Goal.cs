public abstract class Goal
{
    public string Name { get; private set; }
    public int Points { get; protected set; }
    public bool Completed { get; protected set; }

    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
        Completed = false;
    }

    public abstract void RecordEvent();
    public abstract void DisplayStatus();
}
