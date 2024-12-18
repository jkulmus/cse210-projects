using System;

/*
Additional gamification features to enhance user engagement:
- Leveling up for every 1000 points earned
- Earn badges for achieving certain milestones
- Users can track and lose points for bad habits
This will make goal tracking more interactive and rewarding.
*/

class Program
{
    static void Main(string[] args)
    {
        // Create new user and load their data
        User newUser = new User("Jacquelyn");
        newUser.LoadData("user_data.txt");

        // display user info and goals
        newUser.DisplayUserInfo();
        newUser.DisplayGoals();

        GoalManager goalManager = new GoalManager();

        //Create example goals and add them to users goals
        newUser.AddGoal(new SimpleGoal("Run Marathon", "Complete a full marathon", 1000));
        newUser.AddGoal(new EternalGoal("Read Book of Mormon daily", "Do Come Follow Me every week", 100));
        newUser.AddGoal(new ChecklistGoal("Attend the Temple", "Attend the temple 10 times", 50, 10, 500));

        // Add badges
        newUser.AddBadge("First Goal Completed");

        // Display initial goals
        newUser.DisplayGoals();

        //Record events
        goalManager.RecordEvent("Run Marathon");
        goalManager.RecordEvent("Read Book of Mormon");
        goalManager.RecordEvent("Attend the Temple");

        // Calculate level based on points
        newUser.CalculateLevel(goalManager.TotalPoints());

        //Display updated goals, user info, and score
        newUser.DisplayUserInfo();
        goalManager.DisplayPlayerInfo();
        goalManager.ListGoalDetails();

        //Save to file
        goalManager.SaveGoals();

        //Load from file
        goalManager.LoadGoals();
        goalManager.ListGoalDetails();
    }
}