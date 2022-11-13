namespace UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test()
    {
        var circle = new Shapes.Circle(10);
        var triangle = new Shapes.Triangle(1, 2, 3);
        Console.WriteLine(circle.ToString());
        Console.WriteLine(triangle.ToString());
        Assert.Pass();
    }
}