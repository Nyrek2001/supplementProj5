public class CylinderTests
{
    [Fact]
    public void Constructor_ValidInputs_DoesNotThrow()
    {
        var exception = Record.Exception(() => new Cylinder(3, 5));
        Assert.Null(exception);
    }

    [Fact]
    public void Constructor_InvalidInputs_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Cylinder(0, 5));
        Assert.Throws<ArgumentException>(() => new Cylinder(3, -1));
    }

    [Fact]
    public void GetVolume_CorrectCalculation()
    {
        var cylinder = new Cylinder(3, 5);
        Assert.Equal(141.372, cylinder.GetVolume(), precision: 3);
    }

    [Fact]
    public void GetSurfaceArea_CorrectCalculation()
    {
        var cylinder = new Cylinder(3, 5);
        Assert.Equal(150.796, cylinder.GetSurfaceArea(), precision: 3);
    }

    [Fact]
    public void Dump_CorrectFormat()
    {
        var cylinder = new Cylinder(3, 5);
        string expected = "Cylinder: Surface Area = 150.796, Volume = 141.372";
        Assert.Equal(expected, cylinder.Dump());
    }
}
