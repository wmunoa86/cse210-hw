using System;

public class Scripture
{
    private readonly Reference reference;
    private readonly List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = new Reference(reference);
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        foreach (Word word in words)
        {
            if (!word.IsHidden && random.Next(2) == 0)
            {
                word.Hide();
            }
        }
    }

    public override string ToString()
    {
        return $"{reference}: {string.Join(" ", words)}";
    }
}
