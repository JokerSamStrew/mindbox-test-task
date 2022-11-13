using System;
namespace Shapes;

public class Circle : IAreaCalculator
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public bool IsExist()
    {
        return _radius > 0;
    }
    double IAreaCalculator.CalculateArea()
    {
        if (!IsExist())
            throw new ShapesException($"Circle with radius {_radius} cannot exist");

        return _radius * _radius * Math.PI;
    }
}
