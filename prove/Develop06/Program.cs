using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new user and load their data
        User newUser = new User("Name");
        newUser.LoadData("user_data.txt");

        // display user info and goals
        newUser.DisplayUserInfo();
        newUser.DisplayGoals();

        GoalManager goalManager = new GoalManager();

        //Create example goals and add them to users goals
        newUser.AddGoal(new SimpleGoal("Run Marathon", "Complete a full marathon", 1000));
        newUser.AddGoal(new EternalGoal("Read Book of Mormon daily", "Do Come Follow Me every week", 100));
        newUser.AddGoal(new ChecklistGoal("Attend the Temple", "Attend the temple 10 times", 50, 10, 500));

        // Display initial goals
        goalManager.ListGoalNames();

        //Record events
        goalManager.RecordEvent("Run Marathon");
        goalManager.RecordEvent("Read Book of Mormon");
        goalManager.RecordEvent("Attend the Temple");

        //Display updated goals and score
        goalManager.DisplayPlayerInfo();
        goalManager.ListGoalDetails();

        //Save to file
        goalManager.SaveGoals();

        //Load from file
        goalManager.LoadGoals();
        goalManager.ListGoalDetails();
    }
}