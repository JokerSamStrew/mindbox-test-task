using System;
namespace Shapes;

public class Circle : IAreaCalculator
{
    private float _radius;

    public Circle(float radius)
    {
        _radius = radius;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Radius: {_radius}";
    }

    float IAreaCalculator.CalculateArea()
    {
        throw new NotImplementedException();
    }
}
