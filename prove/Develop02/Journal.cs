using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    //Added for new journal entry
    public void AddEntry(string promptText, string entryText, string mood, List<string> tags)
    {
        string date = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry (date, promptText, entryText, mood, tags);
        _entries.Add(newEntry);
    }

    // Display all entries in the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Option to save entries as JSON or CSV format
    public void SaveToFile(string filename, bool isJson = false)
    {
        if (isJson)
        {
            // Serialize entries to JSON and write file
            string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, json);
        }
        else
        {
            // write entries to a CSV file
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    // format CSV line with quotes for each entry
                    string line = $"\"{entry.DisplayDate}\",\"{entry.DisplayPrompt}\",\"{entry.DisplayMood}\",\"{entry.DisplayTags}\"";
                    outputFile.WriteLine(line);
                }
            }
        }
    }

    // Load entries from a file, either JSON or CSV format
    public void LoadFromFile(string filename, bool isJson = false)
    {
        _entries.Clear(); // Clear existing entries
        if (isJson)
        {
            // Read JSON from file and deserialize into entries
            string json = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
        }
        else
        {
            // Read entries from a CSV file
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                // Split the CSV line into parts
                string[] parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
                if (parts.Length >= 4)
                {
                    // Trim quotes
                    for (int i = 0; i < parts.Length; i++)
                    {
                        parts[i] = parts[i].Trim('"');
                    }

                    // Create new entry from parts
                    Entry entry = new Entry(parts[0], parts[1], parts[2], parts[3], new List<string>(parts[4].Split(',')));
                    _entries.Add(entry);
                }
            }
        }
    }
}
