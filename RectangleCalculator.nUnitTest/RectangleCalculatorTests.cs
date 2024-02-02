namespace RectangleCalculator.nUnitTest;

public class RectagleCalculatorTests
{
    private Rectangle _rectangleCalculator { get; set; } = null;
    [SetUp]
    public void Setup()
    {
        _rectangleCalculator = new Rectangle(10, 10);
    }

    [Test]
    public void GetLength_Test1()
    {
        var rect = new Rectangle(10, 10);
        var width = rect.GetLength();
        Assert.AreEqual(10, width);
    }

    [Test]
    public void SetLength_Test1()
    {
        var rect = new Rectangle(10, 10);
        var width = rect.SetLength(20);
        Assert.AreEqual(20, width);
    }

    [Test]
    public void GetWidth_Test1()
    {
        var rect = new Rectangle(10, 10);
        var width = rect.GetWidth();
        Assert.AreEqual(10, width);
    }

    [Test]
    public void SetWidth_Test1()
    {
        var rect = new Rectangle(10, 10);
        var width = rect.SetWidth(30);
        Assert.AreEqual(30, width);
    }

    [Test]
    public void GetPerimeter_Test1()
    {
        var rect = new Rectangle(10, 10);
        var width = rect.GetPerimeter();
        Assert.AreEqual(40, width);
    }

    [Test]
    public void GetArea_Test1()
    {
        var rect = new Rectangle(10, 10);
        var width = rect.GetArea();
        Assert.AreEqual(100, width);
    }
}
