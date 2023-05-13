using System;
using System.Threading;

public class SensesActivity : Activity
{
    public SensesActivity(int duration, string name, string description) : base(duration, name, description)
    {
    }
    private List<string> _prompts = new List<string>
    {
        "Look around you and bring your attention to five things that you can see. Pick something that you don’t normally notice, like a shadow or a small crack in the concrete.",
        "Bring awareness to five things that you are currently feeling, like the texture of your pants, the feeling of the breeze on your skin, or the smooth surface of a table you are resting your hands on.",
        "Take a moment to listen, and note five things that you hear in the background. This can be the chirp of a bird, the hum of the refrigerator, or the faint sounds of traffic from a nearby road.",
        "Bring your awareness to smells that you usually filter out, whether they’re pleasant or unpleasant. Perhaps the breeze is carrying a whiff of pine trees if you’re outside, or the smell of a fast-food restaurant across the street.",
        "Focus on five thing that you can taste right now, at this moment. You can take a sip of a drink, chew a piece of gum, eat something, notice the current taste in your mouth, or even open your mouth to search the air for a taste."
    };
    private List<string> _senses = new List<string>
    {
        "see",
        "feel",
        "hear",
        "smell",
        "taste"
    };
    public (string, string) GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0,_prompts.Count());
        string _prompt = _prompts[randomNumber];
        string _sense = _senses[randomNumber];
        return (_prompt, _sense);
    }
    public void DisplayPrompt()
    {
        var values = GetRandomPrompt();
        string _prompt = values.Item1;
        string _sense = values.Item2;
        int _seconds = GetDuration();
        Console.WriteLine($"Notice five things that you can {_sense} within {_seconds} seconds.");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        DisplayCountDown(8);
        Console.WriteLine();
        GatherResponses();
    }
    public void GatherResponses()
    {
        List<string> listingResponses = new List<string>();
        int numSecondsToRun = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numSecondsToRun);
        do
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            listingResponses.Add(userResponse);
        } while ((listingResponses.Count() < 5) && (DateTime.Now < endTime));

        Console.WriteLine($"You listed {listingResponses.Count()} items!");
        Console.WriteLine();
    }
}
