using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address instances
        Address address1 = new Address("123 Main St", "Springfield", "IL", "62701");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "M4B 1B3");
        Address address3 = new Address("789 Oak St", "Los Angeles", "CA", "90001");

        // Create event instances
        Lecture lecture = new Lecture("Tech Talk", "A lecture on the latest in technology.", "2024-08-15", "10:00 AM", address1, "Dr. John Smith", 100);
        Reception reception = new Reception("Networking Event", "An evening of networking with industry professionals.", "2024-08-20", "6:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "An outdoor picnic with fun activities.", "2024-08-25", "2:00 PM", address3, "Sunny and warm");

        // Put events in a list
        Event[] events = { lecture, reception, outdoorGathering };

        // Iterate through the list of events and display details
        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine(new string('-', 40));
        }
    }
}
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{Street}\n{City}, {State} {ZipCode}";
    }
}
public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Title: {Title}\nDate: {Date}\nTime: {Time}";
    }
}
public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP Email: {RsvpEmail}";
    }
}
public class OutdoorGathering : Event
{
    public string WeatherStatement { get; set; }

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        WeatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather: {WeatherStatement}";
    }
}
