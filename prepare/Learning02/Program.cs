using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Business Systems Analyst";
        job1._company = "Brigham Young University - Idaho";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2019;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Parker Johnson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}