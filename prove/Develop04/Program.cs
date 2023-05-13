using System.IO;
using System.Threading;
// I have added code that will delay the menu display if you have selected 2. this allows for time to view the previous journal entries.
class Program
{
    static void Main(string[] args)
    {
        int menuUserInput = 0;
    List<string> menu = new List<string>
        {
            "Menu Options:",
            "   1. Start Breathing Activity",
            "   2. Start Reflecting Activity",
            "   3. Start Listing Activity",
            "   4. Start Senses Activity",
            "   5. Quit",
            "Select a choice from the menu: "
        };

    bool exitProgram = false;
    while (!exitProgram)
    {
        Console.Clear();
        foreach(string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }
        menuUserInput = int.Parse(Console.ReadLine());
        switch (menuUserInput)
        {
            case 1:
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity(0,"Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.DisplayStartMessage();
                breathingActivity.Breathe();
                breathingActivity.DisplayEndMessage();
                break;
            case 2:
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity(0,"Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.DisplayStartMessage();
                reflectingActivity.DisplayPrompt();
                reflectingActivity.DisplayPromptQuestions();
                reflectingActivity.DisplayEndMessage();
                Console.Clear();
                break;
            case 3:
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity(0,"Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.DisplayStartMessage();
                listingActivity.DisplayPrompt();
                listingActivity.DisplayEndMessage();
                break;
            case 4:
                Console.Clear();
                SensesActivity sensesActivity = new SensesActivity(0,"Senses Activity","This exercise is called 'five senses,' and provides guidelines on practicing mindfulness quickly in nearly any situation. All that is needed is to notice something you are experiencing with one of the five senses.");
                sensesActivity.DisplayStartMessage();
                sensesActivity.DisplayPrompt();
                sensesActivity.DisplayEndMessage();
                break;
            case 5:
                exitProgram = true;
                break;
            default:
                Console.WriteLine("Invalid input, please choose another option.");
                Thread.Sleep(2000);
                Console.Clear();
                break;
        }
    }
    }
}