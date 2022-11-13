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

    [TestCase(3, 4, 5, true)]
    [TestCase(4, 3, 5, true)]
    [TestCase(5, 3, 4, true)]
    [TestCase(7, 5, 3, false)]
    public void SuccessTriangleAreaIsDirectTest(double firstSideSize, double secondSideSize, double thirdSideSize, bool result)
    {
        var triangle = new Triangle(firstSideSize, secondSideSize, thirdSideSize);
        var isDirect = triangle.IsDirect();
        Assert.AreEqual(result, isDirect);
    }

    [TestCase(1, 2, 4)]
    [TestCase(-3, -3, -3)]
    [TestCase(0, 0, 0)]
    public void NotExistErrorTriangleIsDirectTest(double firstSideSize, double secondSideSize, double thirdSideSize)
    {
        try
        {
            var triangle = new Triangle(firstSideSize, secondSideSize, thirdSideSize);
            var area = triangle.IsDirect();
        }
        catch (ShapesException)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }

    [TestCase(1, 2, 4)]
    [TestCase(-3, -3, -3)]
    [TestCase(0, 0, 0)]
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