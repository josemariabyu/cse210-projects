using System;

abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    // Abstract method to get the area of the shape
    public abstract double GetArea();
}
