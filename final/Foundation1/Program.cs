using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Title1", "Author1", 300);
        Video video2 = new Video("Title2", "Author2", 200);
        Video video3 = new Video("Title3", "Author3", 400);

        // Add comments to videos
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Very informative."));
        video1.AddComment(new Comment("User3", "Loved it!"));

        video2.AddComment(new Comment("User4", "Nice content."));
        video2.AddComment(new Comment("User5", "Good job."));
        video2.AddComment(new Comment("User6", "Interesting."));

        video3.AddComment(new Comment("User7", "Excellent presentation."));
        video3.AddComment(new Comment("User8", "Helpful."));
        video3.AddComment(new Comment("User9", "Well explained."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}