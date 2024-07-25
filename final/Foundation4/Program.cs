using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 7, 20), 30, 5),
            new Cycling(new DateTime(2024, 7, 21), 45, 20),
            new Swimming(new DateTime(2024, 7, 22), 60, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}