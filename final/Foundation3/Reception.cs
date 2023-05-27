using System;
class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, string address, string eventType, string email) : base(title, description, date, time, address, eventType)
    {
        _email = email;
    }
    public void DisplayReceptionFullDetails()
    {
        DisplayFullDetails();
        Console.WriteLine($"Email: {_email}");
    }
}