using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructor that initializes to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor that initializes to top/1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor that initializes to top/bottom
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and setters for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getters and setters for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return the fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}