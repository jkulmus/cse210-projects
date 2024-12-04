using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {

    };

    public ListingActivity() : base("Listing", "This activity will help you recognize and list all the good things you have in certain areas of your life.")
    {
    }

    public void Run()
    {
        Start();
    }
}