using System;

public class Program {
    static void Main(string[] args) {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Oak Ave", "Sometown", "NY", "67890");

        Lecture lecture = new Lecture("Introduction to C#", "Learn the basics of C#", new DateTime(2024, 6, 15), new TimeSpan(10, 0, 0), address1, "John Doe", 50);
        Reception reception = new Reception("Networking Mixer", "Join us for networking and refreshments", new DateTime(2024, 7, 10), new TimeSpan(18, 30, 0), address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy food and games outdoors", new DateTime(2024, 8, 20), new TimeSpan(12, 0, 0), address1, "Sunny with a chance of showers");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine(gathering.GenerateStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine(gathering.GenerateFullDetails());

        Console.WriteLine("\nShort Descriptions:");
        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine(gathering.GenerateShortDescription());
    }
}