using System;

public class Program
{
    private static Dictionary<string, int> activityLog = new Dictionary<string, int>();
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Activity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    activity = new GratitudeActivity();
                    break;
                case "5":
                    SaveLog();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity?.Run();
            LogActivity(activity.GetType().Name);
        }
    }
    private static void LogActivity(string activityName)
    {
        if (activityLog.ContainsKey(activityName))
        {
            activityLog[activityName]++;
        }
        else
        {
            activityLog[activityName] = 1;
        }
    }
    private static void SaveLog()
    {
        Console.WriteLine("Saving log. . .");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}