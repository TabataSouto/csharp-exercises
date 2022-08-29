using Xunit;
using FluentAssertions;
using EstruturaCondicional;

namespace EstruturaCondicional.Test;

public class PoligonoTest
{
    // [Fact]
    [Theory(DisplayName = "Deve classificar um polígono.")]
    [InlineData(2,"Não é um polígono")]
    [InlineData(3,"Triângulo")]
    [InlineData(4,"Quadrado")]
    [InlineData(5,"Pentágono")]
    [InlineData(6,"Polígono não identificado")]
    public void TestIdentifyPolygon(int numberSide, string name)
    {
        var resultName = Poligono.IdentifyPolygon(numberSide);

        resultName.Should().Be(name);
    }
}