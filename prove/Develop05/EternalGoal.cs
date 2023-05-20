class EternalGoal : Goal
{
    private const int goalType = 2;
    private bool goalComplete;
    public EternalGoal()
    {
        goalComplete = false;
        DisplayGetGoalName();
        DisplayGetGoalDescription();
        DisplayGetGoalPoints();
    }
    public EternalGoal(string _goalName, String _goalDescription, int _points, bool _goalComplete) : base (_goalName, _goalDescription, _points)
    {
        goalComplete = _goalComplete;
    }
    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}",goalType,GetGoalName(),GetGoalDescription(),GetGoalPoints(),goalComplete);
    }
    public override string ToString()
    {
        return string.Format("[{0}] {1} ({2})", ((goalComplete == false) ? " ": " "), GetGoalName(), GetGoalDescription());
    }
    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("\nCongratulations! You have earned {0}", GetGoalPoints()));
        goalComplete = true;
    }
}