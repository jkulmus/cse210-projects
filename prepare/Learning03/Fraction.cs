using System;

public class Fraction
{
    // private attributes
    private int _top;
    private int _bottom;

    // constructor to initialize fraction 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    
    // constructor to initialize fraction top/bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // method to return the decimal of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}