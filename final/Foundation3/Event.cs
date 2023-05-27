using System;
class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _eventType;
    public Event(string title, string description, string date, string time, string address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }
    public void DisplayShortDescription()
    // List the type of event, title, and the date.
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
    public void DisplayStandardDetails()
    // display the title, description, date, time, and address.
    {
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }
    public void DisplayFullDetails()
    // Lists all of the above, plus type of event and information specific to that event type. 
    // For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. 
    // For outdoor gatherings, this includes a statement of the weather.
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }
}