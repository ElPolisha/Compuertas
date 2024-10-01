namespace Library.Tests;

using Xunit;

public class CompuertaTests
{
    [Fact]
    public void TestCompuertaAND()
    {
        var compuerta = new CompuertaAND("TestAND");
        compuerta.AgregarEntrada("A", 1);
        compuerta.AgregarEntrada("B", 0);

        Assert.Equal(0, compuerta.Calcular());
    }

    [Fact]
    public void TestCompuertaOR()
    {
        var compuerta = new CompuertaOR("TestOR");
        compuerta.AgregarEntrada("A", 1);
        compuerta.AgregarEntrada("B", 0);

        Assert.Equal(1, compuerta.Calcular());
    }

    [Fact]
    public void TestCompuertaNOT()
    {
        var compuerta = new CompuertaNOT("TestNOT");
        compuerta.AgregarEntrada("A", 1);

        Assert.Equal(0, compuerta.Calcular());
    }
}
