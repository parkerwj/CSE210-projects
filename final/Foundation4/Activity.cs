using System;
public abstract class Activity
{
    private string _date;
    private double _length;
    public Activity(double length)
    {
        _length = length;
    }
    public string GetDate()
    {
        DateTime date = DateTime.Now;
        string _date = date.ToString("dd MMM yyyy");
        return _date;
    }
    public void SetDate(string date)
    {

    }
    public double GetLength()
    {
        return _length;
    }
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract void DisplaySummary();
}