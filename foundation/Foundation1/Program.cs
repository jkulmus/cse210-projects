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
        var comment1 = new Comment("name1", "text1");
        var comment2 = new Comment("name2", "text2");
        var comment3 = new Comment("name3", "text3");
        var comment4 = new Comment("name4", "text4");
        var comment5 = new Comment("name5", "text5");

        // Add comments to video
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video2.AddComment(comment3);
        video3.AddComment(comment4);
        video3.AddComment(comment5);

        // Store videos in list
        var videos = new List<Video> {video1, video2, video3 };

        // Display info about each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}