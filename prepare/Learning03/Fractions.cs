using System;

public class Fractions
{
    private int _topNumbers;
    private int _bottomNumbers;

    public Fractions()
    {
        _topNumbers = 1;
        _bottomNumbers = 1;
    }

    public Fractions(int top)
    {
        _topNumbers = top;
        _bottomNumbers = 1;
    }

    public Fractions(int top, int bottom)
    {
        _topNumbers = top;
        _bottomNumbers = bottom;
    }

    public string GetFraction()
    {
        string text = $"{_topNumbers}/{_bottomNumbers}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumbers/(double)_bottomNumbers;
    }
}