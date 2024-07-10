using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public void AddEntry()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        string prompt = prompts[index];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string text = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        entries.Add(new Entry(text, prompt, date));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Entry: {entry.Text}");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Text}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string text = parts[2];
                    entries.Add(new Entry(text, prompt, date));
                }
            }
        }
    }
}