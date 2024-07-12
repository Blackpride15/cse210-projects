using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Load scriptures from file
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found. Please check the scriptures.txt file.");
            return;
        }

        // Select a random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Main loop
        int attempts = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"\nAttempts: {attempts}");

            // Check if the scripture is completely hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Good job!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words, type 'hint' for a hint, or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                scripture.ShowHint();
                continue;
            }

            scripture.HideRandomWords(3); // Hide 3 random words at a time
            attempts++;
        }
    }
    // Now, the program loads multiple scriptures from a file and picks one at random for practice.
    // Scriptures are read from a file, so you can add or update them without changing the code.
    // Hints: Users can get hints showing the first letter of hidden words.
    // Progress Tracking: The program shows the number of attempts, helping you track your progress and also help message guides users on how to get hints or quit the program.
    static List<Scripture> LoadScriptures(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i += 2)
            {
                Reference reference = new Reference(lines[i]);
                string text = lines[i + 1];
                scriptures.Add(new Scripture(reference, text));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
        }
        return scriptures;
    }
}