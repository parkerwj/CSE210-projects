using System.IO;
using System.Threading;
class AllGoals
{
    private List<Goal> allGoals = new List<Goal>();
    private int totalPoints;
    public int GetTotalPoints()
    {
        return totalPoints;
    }
    public void DisplayPoints()
    {
        Console.WriteLine(string.Format("You have {0} points.\n", totalPoints));
    }
    public int GetBonus()
    {
        ChecklistGoal checklistGoal = new ChecklistGoal();
        int getBonus = checklistGoal.GetBonus();
        return getBonus;
    }
    public void AddGoal(Goal _goal)
    {
        allGoals.Add(_goal);
    }
    public void DiplayGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("\nNo goals have been created or loaded.");
            Thread.Sleep(3000);
            return;
        }
        Console.WriteLine("\nThe goals are:");
        int index = 1;
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine(string.Format("   {0}. {1}",index,goal.ToString()));
            index ++;
        }
        Console.WriteLine("\nPress enter to continue.");
        Console.ReadLine();
    }
    public void SaveGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save");
            return;
        }
        string fileToSave = DisplayGetGoalFile();

        List<string> saveGoals = new List<string>();

        saveGoals.Add(totalPoints.ToString());

        foreach (Goal goal in allGoals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }

        using (StreamWriter outputFile = new StreamWriter(fileToSave))
        {
            foreach (string goal in saveGoals)
            {
                outputFile.WriteLine(goal);
            }
        }

        Console.WriteLine("Goals saved.");
    }
    public void LoadGoals()
    {
        Goal goal = null;
        string fileName = DisplayGetGoalFile();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] loadTotalPoints = lines.Take(1).ToArray();
        totalPoints = int.Parse(loadTotalPoints.First());
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] goalParts = line.Split('|');
            int goalType = int.Parse(goalParts[0]);
            switch (goalType)
            {
                case 1:
                    goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]),bool.Parse(goalParts[4]));
                    break;
                case 2:
                    goal = new EternalGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]),bool.Parse(goalParts[4]));
                    break;
                case 3:
                    goal = new ChecklistGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]),bool.Parse(goalParts[4]),int.Parse(goalParts[5]),int.Parse(goalParts[6]),int.Parse(goalParts[7]));
                    break;
                    
            }
            if (goal != null && allGoals.Contains(goal) == false)
            {
                allGoals.Add(goal);
            }
        }
        Console.Write("\nGoals loaded.");
        Thread.Sleep(2000);
    }
    public string DisplayGetGoalFile()
        {
            Console.Write("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();
            return fileName;
        }
    public void DisplayGoalsRecordEvent()
        {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
        }
        Console.WriteLine("\nThe goals are:");
        int index = 1;
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine(string.Format("   {0}. {1}",index,goal.ToString()));
            index ++;
        }
            Console.Write("\nWhich goal did you accomplish? ");
            int recordEvent = int.Parse(Console.ReadLine()) -1;
            allGoals[recordEvent].RecordEvent();
            string test = allGoals[recordEvent].GetType().ToString();
            totalPoints += allGoals[recordEvent].GetGoalPoints() + allGoals[recordEvent].GetBonus();
            Console.WriteLine(string.Format("You now have {0} point(s).", totalPoints.ToString()));
            Thread.Sleep(3000);
        }

}
