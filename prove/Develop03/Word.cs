using System;

public class Word{
    private string _text; // actual word
    private bool _isHidden; // visibility of the word

    // Constructor for word and set it as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false; //words are visible by default
    }

    // Method to hide words
    public void Hide()
    {
        _isHidden = true; // set visibility to hidden
    }

    // method to show the word
    public void Show()
    {
        _isHidden = true; // set visability to visable
    }

    // Method to jhide the word
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text; // Return underscore if hidden
    }
}