using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(3, 4);

        // Test the getters and setters
        Console.WriteLine("Testing getters and setters:");
        fraction1.SetNumerator(1);
        fraction1.SetDenominator(2);
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} - Decimal: {fraction1.GetDecimalValue()}");

        fraction2.SetNumerator(5);
        fraction2.SetDenominator(1);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} - Decimal: {fraction2.GetDecimalValue()}");

        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} - Decimal: {fraction3.GetDecimalValue()}");

        // Test the initial values from constructors
        Console.WriteLine("Testing initial values from constructors:");
        Fraction fraction4 = new Fraction();
        Console.WriteLine($"Fraction 4 (default constructor): {fraction4.GetFractionString()} - Decimal: {fraction4.GetDecimalValue()}");

        Fraction fraction5 = new Fraction(5);
        Console.WriteLine($"Fraction 5 (one parameter): {fraction5.GetFractionString()} - Decimal: {fraction5.GetDecimalValue()}");

        Fraction fraction6 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 6 (two parameters): {fraction6.GetFractionString()} - Decimal: {fraction6.GetDecimalValue()}");
    }
}
