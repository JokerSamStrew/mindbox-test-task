using System;
namespace Shapes;

public class Triangle : IAreaCalculator
{
    private double _firstSideSize;
    private double _secondSideSize;
    private double _thirdSideSize;

    public Triangle(double firstSideSize, double secondSideSize, double thirdSideSize)
    {
        _firstSideSize = firstSideSize;
        _secondSideSize = secondSideSize;
        _thirdSideSize = thirdSideSize;
    }

    public bool IsExist()
    {
        return _firstSideSize < _secondSideSize + _thirdSideSize
        && _secondSideSize < _firstSideSize + _thirdSideSize
        && _thirdSideSize < _firstSideSize + _secondSideSize;
    }

    double IAreaCalculator.CalculateArea()
    {
        if (!IsExist())
            throw new ShapesException($"Triangle with sides Side1: {_firstSideSize}, Side2: {_secondSideSize}, Side3: {_secondSideSize} cannot exist");

        var p = (_firstSideSize + _secondSideSize + _thirdSideSize) / 2;
        return Math.Sqrt(p * (p - _firstSideSize) * (p - _secondSideSize) * (p - _thirdSideSize));
    }
}
