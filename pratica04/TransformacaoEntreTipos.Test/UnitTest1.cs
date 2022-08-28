using Xunit;
using FluentAssertions;

namespace TransformacaoEntreTipos.Test;

public class UnitTest1
{
    [Fact]
    public void TestVariableCreation()
    {
    Class1 instance = new();

    var response = instance.someString is string;
    response.Should().Be(true);
    }

    [Fact]
    public void TestVariableTransform()
    {
        Class1 instance = new();

        instance.intEntry.Should().Be(42);
        var isInt = instance.intEntry is int;
        isInt.Should().Be(true);

        instance.Transform();
        instance.doubleResponse.Should().Be(42.0);
        var isDouble = instance.doubleResponse is double;
        isDouble.Should().Be(true);
    }
}