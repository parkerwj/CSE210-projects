using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        Running r1 = new Running(30,3);
        activityList.Add(r1);

        Cycling c1 = new Cycling(45, 16);
        activityList.Add(c1);

        Swimming s1 = new Swimming(60,40);
        activityList.Add(s1);

        // Display Activity Summary
        foreach(Activity activity in activityList)
        {
            activity.DisplaySummary();
        }


    }
}