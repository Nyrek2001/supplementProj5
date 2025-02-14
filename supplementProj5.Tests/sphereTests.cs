public class SphereTests
{
    [Fact]
    public void Constructor_ValidRadius_DoesNotThrow()
    {
        var exception = Record.Exception(() => new Sphere(4));
        Assert.Null(exception);
    }

    [Fact]
    public void Constructor_InvalidRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Sphere(0));
        Assert.Throws<ArgumentException>(() => new Sphere(-2));
    }

    [Fact]
    public void GetVolume_CorrectCalculation()
    {
        var sphere = new Sphere(3);
        Assert.Equal(113.097, sphere.GetVolume(), precision: 3);
    }

    [Fact]
    public void GetSurfaceArea_CorrectCalculation()
    {
        var sphere = new Sphere(3);
        Assert.Equal(113.097, sphere.GetSurfaceArea(), precision: 3);
    }

    [Fact]
    public void Dump_CorrectFormat()
    {
        var sphere = new Sphere(3);
        string expected = "Sphere: Surface Area = 113.097, Volume = 113.097";
        Assert.Equal(expected, sphere.Dump());
    }
}
