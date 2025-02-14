using System;
using Xunit;

public class CubeTests
{
    [Fact]
    public void Constructor_ValidSide_DoesNotThrow()
    {
        var exception = Record.Exception(() => new Cube(5));
        Assert.Null(exception);
    }

    [Fact]
    public void Constructor_InvalidSide_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Cube(0));
        Assert.Throws<ArgumentException>(() => new Cube(-3));
    }

    [Fact]
    public void GetVolume_CorrectCalculation()
    {
        var cube = new Cube(3);
        Assert.Equal(27, cube.GetVolume(), precision: 2);
    }

    [Fact]
    public void GetSurfaceArea_CorrectCalculation()
    {
        var cube = new Cube(3);
        Assert.Equal(54, cube.GetSurfaceArea(), precision: 2);
    }

    [Fact]
    public void Dump_CorrectFormat()
    {
        var cube = new Cube(2);
        string expected = "Cube: Surface Area = 24, Volume = 8";
        Assert.Equal(expected, cube.Dump());
    }
}
