using System;
using System.Threading;
public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>
    {
        "> Why was this experience meaningful to you? ",
        "> Have you ever done anything like this before? ",
        "> How did you get started? ",
        "> How did you feel when it was complete? ",
        "> What made this time different than other times when you were not as successful? ",
        "> What is your favorite thing about this experience? ",
        "> What could you learn from this experience that applies to other situations? ",
        "> What did you learn about yourself through this experience? ",
        "> How can you keep this experience in mind in the future? "
    };
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is the most difficult thing I am trying to accomplish today?",
        "What is one small example of how I have “personalized” my life for the better?"
    };
    public ReflectingActivity(int duration, string name, string description) : base(duration, name, description)
    {
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(0,_questions.Count());
        string _question = _questions[randomNumber];
        return _question;
    }
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
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

    }
    public void DisplayPromptQuestions()
    {
        Console.WriteLine($"Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration()); 

        do
        {
            string _question = GetRandomQuestion();
            Console.Write($"{_question}");
            DisplaySpinner(10);
            Console.WriteLine();
        } while (DateTime.Now < endTime);
        Console.WriteLine();
    }
}