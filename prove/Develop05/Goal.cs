using System;

abstract class Goal
{
    private string goalName, goalDescription;
    private int goalPoints;

    public Goal()
    {
    }
    public Goal(string _goalName, string _goalDescription, int _goalPoints)
    {
        goalName = _goalName;
        goalDescription = _goalDescription;
        goalPoints = _goalPoints;
    }
    public void DisplayGetGoalName()
    {   
        Console.Write("\nWhat is the name of your goal? ");
        goalName = Console.ReadLine();
    }
    public void DisplayGetGoalDescription()
    {
        Console.Write("What is a short description of your goal? ");
        goalDescription = Console.ReadLine();
    }
    public void DisplayGetGoalPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        goalPoints = int.Parse(Console.ReadLine());
    }
    public abstract string ToCSVRecord();
    public abstract void RecordEvent();
    public String GetGoalName()
    {
        return goalName;
    }
    public string GetGoalDescription()
    {
        return goalDescription;
    }
    public int GetGoalPoints()
    {
        return goalPoints;
    }
}