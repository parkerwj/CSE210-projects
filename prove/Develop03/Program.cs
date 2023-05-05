using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the lord with all thine heard and lean not unto thine own understanding, in all they ways acknoledge him and he shall direct they paths.");
        
        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            // This will clear the console.
            Console.Clear();
            // This will enter the reference and scripture text.
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish:");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
            // This will select random words to remove from the program.
        }
        // This will display the complete scripture again so the user can check themselves.
        Console.Clear();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Good work!");
    }
}