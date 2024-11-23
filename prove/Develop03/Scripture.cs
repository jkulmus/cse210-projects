using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference; // scripture reference
    private List<Word> _words; // List of words in scriptures

    // Constructor to reference and split text into words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text into words and create Word objects
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide specific number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            // Randomly selected word to hide
            int index = random.Next(_words.Count);
            _words[index].Hide(); // hide selected word
        }
    }

    // Method to get display text of scritpure
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n"; // get reference text
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " "; // Add each words display text
        }
        return displayText.TrimEnd(); // Remove trailing spaces
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) // if there are visible words, it will return falst
                return false;
        }
        return true; // when all words are hidden
    }
}