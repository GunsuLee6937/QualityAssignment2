namespace RectangleCalculator.nUnitTest;

public class RectangleCalculatorTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void GetLength_Test1()
    {
        Rectangle rect = new Rectangle(10, 10);
        int length = rect.GetLength();
        Assert.AreEqual(10, length);
    }

    [Test]
    public void GetLength_Test2()
    {
        Rectangle rect = new Rectangle(10, 10);
        rect.SetLength(20);
        int length = rect.GetLength();
        Assert.AreEqual(20, length);
    }

    [Test]
    public void GetLength_Test3()
    {
        Rectangle rect = new Rectangle();
        int length = rect.GetLength();
        Assert.AreEqual(1, length);
    }

    [Test]
    public void SetLength_Test1()
    {
        Rectangle rect = new Rectangle(10, 10);
        rect.SetLength(20);
        Assert.AreEqual(20, rect.GetLength());
    }

    [Test]
    public void SetLength_Test2()
    {
        Rectangle rect = new Rectangle(10, 10);
        int length = rect.SetLength(20);
        Assert.AreEqual(20, length);
    }

    [Test]
    public void SetLength_Test3()
    {
        Rectangle rect = new Rectangle(10, 10);
        int length =rect.SetLength(Int32.MaxValue);
        Assert.AreEqual(Int32.MaxValue, length);
    }

    [Test]
    public void GetWidth_Test1()
    {
        var rect = new Rectangle(10, 10);
        var width = rect.GetWidth();
        Assert.AreEqual(10, width);
    }

    [Test]
    public void GetWidth_Test2()
    {
        Rectangle rect = new Rectangle(10, 10);
        rect.SetWidth(20);
        int width = rect.GetWidth();
        Assert.AreEqual(20, width);
    }

    [Test]
    public void GetWidth_Test3()
    {
        Rectangle rect = new Rectangle();
        int width = rect.GetWidth();
        Assert.AreEqual(1, width);
    }

    [Test]
    public void SetWidth_Test1()
    {
        var rect = new Rectangle(10, 10);
        var width = rect.SetWidth(30);
        Assert.AreEqual(30, width);
    }

    [Test]
    public void SetWidth_Test2()
    {
        Rectangle rect = new Rectangle(10, 10);
        int width = rect.SetWidth(20);
        Assert.AreEqual(20, width);
    }

    [Test]
    public void SetWidth_Test3()
    {
        Rectangle rect = new Rectangle(10, 10);
        int width = rect.SetWidth(Int32.MaxValue);
        Assert.AreEqual(Int32.MaxValue, width);
    }

    [Test]
    public void GetPerimeter_Test1()
    {
        Rectangle rect = new Rectangle(10, 10);
        int perimeter = rect.GetPerimeter();
        Assert.AreEqual(40, perimeter);
    }

    [Test]
    public void GetPerimeter_Test2()
    {
        Rectangle rect = new Rectangle();
        int perimeter = rect.GetPerimeter();
        Assert.AreEqual(4, perimeter);
    }

    [Test]
    public void GetPerimeter_Test3()
    {
        Rectangle rect = new Rectangle(5, 3);
        int perimeter = rect.GetPerimeter();
        Assert.AreEqual(16, perimeter);
    }

    [Test]
    public void GetArea_Test1()
    {
        Rectangle rect = new Rectangle(10, 10);
        int area = rect.GetArea();
        Assert.AreEqual(100, area);
    }

    [Test]
    public void GetArea_Test2()
    {
        Rectangle rect = new Rectangle();
        int area = rect.GetArea();
        Assert.AreEqual(1, area);
    }

    [Test]
    public void GetArea_Test3()
    {
        Rectangle rect = new Rectangle(10000, 20000);
        int area = rect.GetArea();
        Assert.AreEqual(200000000, area);
    }
}
