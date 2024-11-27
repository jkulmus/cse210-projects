using System;

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    // Constuctor
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}