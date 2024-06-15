using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letter = "";

        if (percentage >= 90) { letter = "A"; }
        else if (percentage >= 80) { letter = "B"; }
        else if (percentage >= 70) { letter = "C"; }
        else if (percentage >= 60) { letter = "D"; }
        else { letter = "F"; }

        Console.WriteLine($"Your letter grade is: {letter}");
        if (percentage >= 70) { Console.WriteLine("Congratulations, you passed the class!"); }
        else { Console.WriteLine("Keep trying, you'll get it next time!"); }
    }
}