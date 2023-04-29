using System.IO;
using System.Threading;
// I have added code that will delay the menu display if you have selected 2. this allows for time to view the previous journal entries.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menuUserInput = 0;
    List<string> menu = new List<string>
        {
            "Please select on of the following Choices:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do?"
        };
    List<string> generatePrompt = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is the most difficult thing I am trying to accomplish today?",
        "What is one small example of how I have “personalized” my life for the better?"
    };
    Journal myJournal = new Journal();
    bool exitProgram = false;
    while (!exitProgram)
    {
        foreach(string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }
        menuUserInput = int.Parse(Console.ReadLine());

        switch (menuUserInput)
        {
            case 1:
                Random random = new Random();
                int randomNumber = random.Next(1,6);
                Entry entry1 = new Entry();
                entry1._prompt = generatePrompt[randomNumber];
                Console.WriteLine(entry1._prompt);
                Console.Write("> ");
                entry1._response = Console.ReadLine();
                myJournal._entries.Add(entry1);
                break;
            case 2:
                myJournal.DisplayJournalEntries();
                Thread.Sleep(5000);
                break;
            case 3:
                Console.Write("What is the file name? (ex. myFile.csv) ");
                string loadFilename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(loadFilename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    Entry loadEntry = new Entry();
                    loadEntry._prompt = parts[0];
                    loadEntry._response = parts[1];
                    loadEntry._date = parts[2];
                    myJournal._entries.Add(loadEntry);
}
                break;
            case 4:
                Console.Write("What is the file name? (ex. myFile.csv): ");
                string saveFilename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(saveFilename))
                {
    
                    foreach (Entry entry in myJournal._entries)
                    {
                        outputFile.WriteLine($"{entry._prompt}|{entry._response}|{entry._date}");
                    }


                }
                break;
            case 5:
                exitProgram = true;
                break;
            default:
                Console.WriteLine("Invalid Input, Please choose another option.");
                break;


        }
    }
   }
}