﻿using Packt.Shared;

public class Circle : Shape
{
    public override double Area
    {
        get
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Equivalente a lo de arriba
    //public override double Area => Math.PI * Radius * Radius;

    public double Radius { get; set; }
}