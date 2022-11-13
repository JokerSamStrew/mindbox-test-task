namespace UnitTests;
using Shapes;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(10, 314.15926535897933)]
    public void SuccessCircleAreaCalculationTest(double radius, double result)
    {
        var circle = new Circle(radius);
        var area = (circle as IAreaCalculator).CalculateArea();
        Assert.AreEqual(result, area);
    }

    [TestCase(3, 3, 3, 3.897114317029974)]
    public void SuccessTriangleAreaCalculationTest(double firstSideSize, double secondSideSize, double thirdSideSize, double result)
    {
        var triangle = new Triangle(firstSideSize, secondSideSize, thirdSideSize);
        var area = (triangle as IAreaCalculator).CalculateArea();
        Assert.AreEqual(result, area);
    }

    [TestCase(1, 2, 4)]
    [TestCase(-3, -3, -3)]
    public void NotExistErrorTriangleAreaCalculationTest(double firstSideSize, double secondSideSize, double thirdSideSize)
    {
        try
        {
            var triangle = new Triangle(firstSideSize, secondSideSize, thirdSideSize);
            var area = (triangle as IAreaCalculator).CalculateArea();
        }
        catch (ShapesException)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }

    [TestCase(-2)]
    [TestCase(0)]
    public void NotExistErrorCircleAreaCalculationTest(double radius)
    {
        try
        {
            var circle = new Circle(radius);
            var area = (circle as IAreaCalculator).CalculateArea();
        }
        catch (ShapesException)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }
}