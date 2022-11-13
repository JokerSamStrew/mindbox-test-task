using System;
namespace Shapes;

public class Triangle : IAreaCalculator
{
    private double[] _sides;

    public Triangle(double firstSideSize, double secondSideSize, double thirdSideSize)
    {
        _sides = new double[]{ firstSideSize, secondSideSize, thirdSideSize };
    }

    public bool IsExist()
    {
        return _sides[0] < _sides[1] + _sides[2]
        && _sides[1] < _sides[0] + _sides[2]
        && _sides[2] < _sides[0] + _sides[1];
    }

    double IAreaCalculator.CalculateArea()
    {
        if (!IsExist())
            throw new ShapesException($"Triangle with sides Side1: {_sides[0]}, Side2: {_sides[1]}, Side3: {_sides[2]} cannot exist");

        var p = (_sides[0] + _sides[1] + _sides[2]) / 2;
        return Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
    }
}
