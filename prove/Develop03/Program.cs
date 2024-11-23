using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize scriptures to load from
        List<Scripture> scriptures = LoadScriptures();

        // Randomly select scripture of list
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Clear console and display chosen scripture
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        // Main loop to hide words untill all are hidden or user quits
        while (true)
        {
            Console.WriteLine("Press Enter to hide some words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // hide 3 random words
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congradulations! All words have been hidden.");
                break;
            }
        }
    }

    // method to load scriptures into a list
    private static List<Scripture> LoadScriptures()
    {
        // Examples of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5-6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct they paths."),
            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me.")
        };
        return scriptures;
    }
}