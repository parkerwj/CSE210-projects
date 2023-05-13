using System;
using System.Threading;

public class ListingActivity : Activity
{
    public ListingActivity(int duration, string name, string description) : base(duration, name, description)
    {
    }
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0,_prompts.Count());
        string _prompt = _prompts[randomNumber];
        return _prompt;
    }
    public void DisplayPrompt()
    {
        string _prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        DisplayCountDown(5);
        Console.WriteLine();
        GatherResponses();
    }
    public void GatherResponses()
    {
        List<string> listingResponses = new List<string>();
        {
        int numSecondsToRun = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numSecondsToRun);

        do
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            listingResponses.Add(userResponse);
        } while (DateTime.Now < endTime);

        Console.WriteLine($"You listed {listingResponses.Count()} items!");
        Console.WriteLine();
        }
    }
}