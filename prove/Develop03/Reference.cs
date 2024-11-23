using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for single verse reference
    public Reference(string book, int chapter, int verse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse; // If no end verse, set to -1
    }

    // Method to get display text of reference
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter};{_verse}";
        }
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}