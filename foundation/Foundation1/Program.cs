using System;
using System.Net.Security;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("title", "author", 1);
        var video2 = new Video("title", "author", 2);
        var video3 = new Video("title", "author", 3);

        // Create comment
        var comment1 = new Comment("User1", "comment1");
        var comment2 = new Comment("User2", "comment2");
        var comment3 = new Comment("User3", "comment3");
        var comment4 = new Comment("User4", "comment4");
        var comment5 = new Comment("User5", "comment5");
        var comment6 = new Comment("User6", "comment6");
        var comment7 = new Comment("User8", "comment8");

        // Add comments to video
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);
        video3.AddComment(comment5);
        video3.AddComment(comment6);
        video3.AddComment(comment7);

        // Store videos in list
        var videos = new List<Video> { video1, video2, video3 };

        // Display info about each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}