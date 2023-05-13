using System;
public class Activity
{
    private int _duration;
    private string _name;
    private string _description;
    List<string> animationString = new List<string>
    {
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\"
    };
    
    public Activity(int duration, string name, string description)
    {
        _duration = duration;
        _name = name;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        int userDuration = int.Parse(Console.ReadLine());
        SetDuration(userDuration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(5);
        Console.WriteLine();
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        DisplaySpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        DisplaySpinner(5);
    }
    public void DisplaySpinner(int numSecondsToRun)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numSecondsToRun);
        
        int i = 0; 

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
    
        }
    }

}
