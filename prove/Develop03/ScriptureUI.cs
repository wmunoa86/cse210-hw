using System;

public class ScriptureUI
{
    private readonly Scripture scripture;

    public ScriptureUI(Scripture scripture)
    {
        this.scripture = scripture;
    }

    public void Start()
    {
        do
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

        } while (!scripture.AllWordsHidden());
    }
}