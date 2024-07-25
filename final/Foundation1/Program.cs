using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating videos
        Video video1 = new Video("Baking cake", "Blessing", 600);
        Video video2 = new Video("The saviour", "John", 800);
        Video video3 = new Video("Component design", "Alice", 1200);
        Video video4 = new Video("Cooking Class", "Michael", 2000);

        // Adding comments to the videos
        // Adding comments to the videos
        video1.AddComment(new Comment("Sarah", "This tutorial is very helpful."));
        video1.AddComment(new Comment("Emily", "I understand it much better now, thanks!"));
        video1.AddComment(new Comment("Mark", "The video is quite short. Could you make a longer one?"));

        video2.AddComment(new Comment("Anna", "This video is fantastic!"));
        video2.AddComment(new Comment("Paul", "I feel uplifted watching this."));
        video2.AddComment(new Comment("Laura", "I would love to learn more about this topic."));

        video3.AddComment(new Comment("David", "Python seems easy with your guide."));
        video3.AddComment(new Comment("Lucy", "Awesome video!"));
        video3.AddComment(new Comment("Henry", "Your tutorials are incredibly useful."));

        video4.AddComment(new Comment("Grace", "Your cooking tips are amazing."));
        video4.AddComment(new Comment("Olivia", "I'm going to try this recipe soon."));
        video4.AddComment(new Comment("Ethan", "This dish looks so tasty!"));
        // Putting the videos into a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Displaying information about the videos
        foreach (var video in videos)
        {
            Console.WriteLine(video);
        }
    }
}