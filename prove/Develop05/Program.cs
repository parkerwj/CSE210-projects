using System;
using System.Threading;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;

        while (userMainMenuSelection != 6)
        {
            Console.Clear();
            allGoals.DisplayPoints();
            userMainMenuSelection = menu.DisplayGetMainMenu();

            switch (userMainMenuSelection)
            {
            case 1:
                int createNewGoalSelection = menu.DisplayGetCreateNewGoalMenu();
                Goal goal = null;
                switch (createNewGoalSelection)
                {
                    case 1:
                        goal = new SimpleGoal();
                        break;

                    case 2:
                        goal = new EternalGoal();
                        break;
                    
                    case 3:
                        goal = new ChecklistGoal();
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again. ");
                        break;
                }
                if (goal != null)
                {
                    allGoals.AddGoal(goal);
                }
                break;
            case 2:
                allGoals.DiplayGoals();
                break;
            case 3:
                allGoals.SaveGoals();
                break;
            case 4:
                allGoals.LoadGoals();
                break;
            case 5:
                allGoals.DisplayGoalsRecordEvent();
                break;
        
            }
        }

    }
}