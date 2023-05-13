using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(int duration, string name, string description) : base(duration, name, description)
    {
    }
    public void Breathe()
    {
        int numSecondsToRun = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numSecondsToRun);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            DisplayCountDown(4);
            Console.WriteLine();
            Console.Write("now breathe out... ");
            DisplayCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\b \b");

        }
    }
}