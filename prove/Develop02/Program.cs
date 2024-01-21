using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Entry> journal = new List<Entry>();
    static string currentFileName = "";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        journal.Add(newEntry);

        Console.WriteLine("Entry saved successfully.\n");
    }

    static void DisplayJournal()
    {
        if (journal.Count == 0)
        {
            Console.WriteLine("Journal is empty.\n");
            return;
        }

        foreach (var entry in journal)
        {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journal)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }

            Console.WriteLine($"Journal saved to {fileName} successfully.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}\n");
        }
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            List<Entry> loadedJournal = new List<Entry>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];

                    loadedJournal.Add(new Entry { Date = date, Prompt = prompt, Response = response });
                }
            }

            journal = loadedJournal;
            currentFileName = fileName;

            Console.WriteLine($"Journal loaded from {fileName} successfully.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}\n");
        }
    }

    static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            // Add your own prompts here
        };

        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}

class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
}
