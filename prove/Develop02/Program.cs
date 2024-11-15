using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
          Journal journal = new Journal();
          PromptGenerator promptGenerator = new PromptGenerator();

          // Start reminder task
          Task.Run(async () =>
          {
            while (true)
            {
                await Task.Delay(TimeSpan.FromHours(24)); // Daily reminder
                Console.WriteLine("History in the making! It's journal time :)"); // journaling prompt
            }
          });

          while (true)
          {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file (CSV)");
            Console.WriteLine("4. Save journal to file (JSON)");
            Console.WriteLine("5. Load journal from file (CSV)");
            Console.WriteLine("6. Load journal from file (JSON)");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Your entry: ");
                    string entryText = Console.ReadLine();
                    Console.Write("Your mood: ");
                    string mood = Console.ReadLine();
                    Console.Write("Enter tags (comma separated): ");
                    List<string> tags = new List<string>(Console.ReadLine().Split(','));
                    journal.AddEntry(prompt, entryText, mood, tags);
                    break;
                
                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save (CSV): ");
                    string saveCsvFilename = Console.ReadLine();
                    journal.SaveToFile(saveCsvFilename, false);
                    Console.WriteLine("Journal saved to CSV.");
                    break;

                case "4":
                    Console.Write("Enter filename to save (JSON): ");
                    string saveJsonFilename = Console.ReadLine();
                    journal.SaveToFile(saveJsonFilename, true);
                    Console.WriteLine("Journal saved to JSON.");
                    break;
                
                case "5":
                    Console.Write("Enter filename to load (CSV): ");
                    string loadCsvFilename = Console.ReadLine();
                    journal.LoadFromFile(loadCsvFilename, false);
                    Console.WriteLine("Journal loaded from CSV.");
                    break;
                
                case "6":
                    Console.Write("Enter filename to load (JSON): ");
                    string loadJsonFilename = Console.ReadLine();
                    journal.LoadFromFile(loadJsonFilename, true);
                    Console.WriteLine("Journal loaded from JSON.");
                    break;

                case "7":
                    return;
                
                default:
                    Console.WriteLine ("Invalid option, please try again.");
                    break;
                }
            }
    }
}