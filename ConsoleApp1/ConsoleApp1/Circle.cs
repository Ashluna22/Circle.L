﻿using System;

public class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateDiameter()
    {
        return 2 * radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public void Grow()
    {
        radius *= 2;
    }

    public double GetRadius()
    {
        return radius;
    }
}
