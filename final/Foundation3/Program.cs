using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Springfield", "IL", "62704", "USA");
        Address receptionAddress = new Address("456 Elm St", "Metropolis", "NY", "10001", "USA");
        Address outdoorAddress = new Address("789 Oak Ave", "Gotham", "NJ", "07030", "USA");

        Lecture lecture = new Lecture(
            "The Future of AI",
            "An in-depth look into the advancements and future prospects of Artificial Intelligence.",
            "May 20, 2024",
            "06:30 PM",
            lectureAddress,
            "Dr. Jane Smith",
            150
        );

        Reception reception = new Reception(
            "Annual Company Gala",
            "Join us for an evening of celebration and networking.",
            "June 15, 2024",
            "07:00 PM",
            receptionAddress,
            "rsvp@company.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Summer Music Festival",
            "Enjoy live performances from top artists in a beautiful outdoor setting.",
            "July 10, 2024",
            "04:00 PM",
            outdoorAddress,
            "Sunny with a chance of light showers."
        );

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("=== Full Details ===");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("=== Short Description ===");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n------------------------------\n");
        }
    }
}
