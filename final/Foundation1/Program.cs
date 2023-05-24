using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> allVideos = new List<Video>();

        Video v1 = new Video("Secret Houseplant Care Tips From a Master Houseplant Grower", "Epic Gardening", 1656);
        allVideos.Add(v1);
        v1.SetComments("Luke Blossom","Love the video! Just wanted to let you know that the “Philodendron Brasil” is actually a varigated Cnathea/Calathea of some sort.");
        v1.SetComments("Leeroy Wolphagen","One of my dreams is to have a greenhouse like this. Plants are very beautiful, peaceful and very attractive. Can't never get enough of it.");
        v1.SetComments("Ellie - Da Plant Baby","The Spiritus seems to be doing great after a part of it was stolen in 2020! Glad to see it is still growing well.");
        v1.SetComments("Helen McCellen","So interesting! Thank you for taking us on this journey. I liked how they had healthy and unhealthy plants so people can see the difference.");

        Video v2 = new Video("Conservatory At Biltmore Estate", "Asheville Tammy", 415);
        allVideos.Add(v2);
        v2.SetComments("Taman Kecil","Thanks your sharing...");
        v2.SetComments("Melania Monica Craciun","Start gardening everybody plizzzzzz, only watching such videos, my heart starts blooming guys.");
        v2.SetComments("Shanti Das Village Vlog","Awesome!");

        Video v3 = new Video("How to Create a Tropical Garden | 10 Tips to Transform your Garden", "Leafing Around", 594);
        allVideos.Add(v3);
        v3.SetComments("Merryquant Agency","This is by far the most impressive garden creativity I have found on YouTube. What a talent!");
        v3.SetComments("Kathryn Jace","I seriously can't understand how can people dislike this video. I have no words to describe this garden this is simply awesome.");
        v3.SetComments("Santi Roberts","It is so nice to see another person with the same interests and vision as I have for creating a little heaven in your garden.");

        Console.WriteLine();
        foreach (var i in allVideos)
        {
            i.DisplayVideoDetails();
            Console.WriteLine("============================================================================================================================================");

        }
    }
}