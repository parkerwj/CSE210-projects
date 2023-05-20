class ChecklistGoal : Goal
{
    private const int goalType = 3;
    private bool goalComplete;
    private int goalAmount;
    private int goalBonus;
    private int goalAttempts;
    public ChecklistGoal()
    {
        goalComplete = false;
        DisplayGetGoalName();
        DisplayGetGoalDescription();
        DisplayGetGoalPoints();
        DisplayGetGoalAmount();
        DisplayGetBonus();
    }
    public ChecklistGoal(string _goalName, String _goalDescription, int _points, bool _goalComplete, int _goalAmount, int _goalAttempts, int _goalBonus) : base (_goalName, _goalDescription, _points)
    {
        goalComplete = _goalComplete;
        goalAmount = _goalAmount;
        goalBonus = _goalBonus;
        goalAttempts = _goalAttempts;
    }
   public void DisplayGetGoalAmount()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        goalAmount = int.Parse(Console.ReadLine());
    }
    
    public void DisplayGetBonus()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        goalBonus = int.Parse(Console.ReadLine());
    }
    public override int GetBonus()
    {
        if (goalAttempts == goalAmount)
        {
            return goalBonus;
        }
        else
        {
            return 0;
        }
    }
    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", goalType, GetGoalName(), GetGoalDescription(), GetGoalPoints(), goalComplete, goalAmount, goalAttempts, goalBonus);
    }
    public override string ToString()
    {
        return string.Format("[{0}] {1} ({2}) -- Currently completed: {3}/{4}", ((goalComplete == false) ? " ": "X"), GetGoalName(), GetGoalDescription(), goalAttempts, goalAmount);
    }
    public override void RecordEvent()
    {
        goalAttempts ++;
        if (goalAttempts == goalAmount)
        {
            Console.WriteLine(string.Format("\nCongratulations! You have earned {0} point(s) and {1} bonus point(s).", GetGoalPoints(),GetBonus()));
            goalComplete = true;
        }
        else
        {
            Console.WriteLine(string.Format("\nCongratulations! You have earned {0} point(s).", GetGoalPoints()));
        }

    }
}