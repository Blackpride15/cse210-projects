using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "City1", "State1", "USA");
        Address address2 = new Address("456 Elm St", "City2", "State2", "Canada");

        // Create events
        Lecture lecture = new Lecture("Lecture on C#", "An in-depth look at C#", new DateTime(2024, 8, 15), "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Company Reception", "Annual company reception", new DateTime(2024, 8, 20), "6:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Company summer picnic", new DateTime(2024, 8, 25), "12:00 PM", address1, "Sunny");

        // Store events in a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event information
        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("\n-----------------------\n");
        }
    }
}
