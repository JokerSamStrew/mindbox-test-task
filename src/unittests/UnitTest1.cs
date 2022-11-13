namespace unittests;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        shapes.Shape.TestFunction();
        Assert.Pass();
    }
}