namespace StaticClassesAndMethods;

using FluentAssertions;

public class UnitTest1
{
    [Fact]
    public void ShouldBeAbleToConvertTopSpeed()
    {
        var car = new Car();
        car.TopSpeed = 100;

        car.TopSpeed.Should().Be(100);
        car.TopSpeedMph.Should().BeApproximately(62.13, 0.10);
    }

    [Fact]
    public void HasKphToMphStaticMethod()
    {
        Car.KphToMph(100).Should().BeApproximately(62.13, 0.1);
    }
}