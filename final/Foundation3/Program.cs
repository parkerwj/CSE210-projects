using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("2800 Opryland Dr.","Nashville","TN","37214","USA");
        string lectureAddress = a1.GetAddress();
        Lecture l1 = new Lecture("Anthology Together","Anthology Together is the destination for education professionals featuring keynotes by industry thought leaders, peer-driven discussions, best practices sharing, and a variety of networking opportunities. Learn from the best institutions and organizations in education on how they inspire and achieve greatness and hear from industry thought leaders, education professionals, and learners from all backgrounds and life experiences about the key issues and trends in EdTech that will drive innovation now and in the future.","July 17-20, 2023","8:00 AM",$"{lectureAddress}","Lecture","Amy Shugart",300);

        //Display Lecture Details
        string lines = "==========================================================";
        Console.WriteLine(lines);
        l1.DisplayShortDescription();
        Console.WriteLine();
        l1.DisplayStandardDetails();
        Console.WriteLine();
        l1.DisplayLectureFullDetails();

        Address a2 = new Address("747 Howard St.","San Francisco","CA","94103","USA");
        string receptionAddress = a2.GetAddress();
        Reception r1 = new Reception("Parker and Abbey","Wedding reception for Parker and Abbey","July 26, 2023","5:30 PM",$"{receptionAddress}","Reception","pjoh@gmail.com");

        // Display Reception Details
        Console.WriteLine(lines);
        r1.DisplayShortDescription();
        Console.WriteLine();
        r1.DisplayStandardDetails();
        Console.WriteLine();
        r1.DisplayReceptionFullDetails();

        Address a3 = new Address("2909 E Willow Hollow","Sandy","UT","84093","USA");
        string outdoorAddress = a3.GetAddress();
        Outdoor o1 = new Outdoor("Soccer Tournament","5-6 year old soccer tournament","May 31, 2023","8:30 AM",$"{outdoorAddress}","Outdoor","Sunny");

        // Display Outdoor Details
        Console.WriteLine(lines);
        o1.DisplayShortDescription();
        Console.WriteLine();
        o1.DisplayStandardDetails();
        Console.WriteLine();
        o1.DisplayFullDetails();

    }
}