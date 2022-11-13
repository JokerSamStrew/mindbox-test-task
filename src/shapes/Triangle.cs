using System;
namespace Shapes;

public class Triangle : Shapes.IAreaCalculator
{
    private float _firstSideSize;
    private float _secondSideSize;
    private float _thirdSideSize;

    public Triangle(float firstSideSize, float secondSideSize, float thirdSideSize)
    {
        _firstSideSize = firstSideSize;
        _secondSideSize = secondSideSize;
        _thirdSideSize = thirdSideSize;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Side1: {_firstSideSize}, Side2: {_secondSideSize}, Side3: {_thirdSideSize}";
    }

    float Shapes.IAreaCalculator.CalculateArea()
    {
        throw new NotImplementedException();
    }
}
