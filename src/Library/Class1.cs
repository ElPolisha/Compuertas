using Xunit;
using Library;

public class CompuertaTests
{
    [Fact]
    public void PruebaAND()
    {
        var compuertaAND = new CompuertaAND("AND");
        compuertaAND.AgregarEntrada(1);
        compuertaAND.AgregarEntrada(0);

        Assert.Equal(0, compuertaAND.Calcular());
    }

    [Fact]
    public void PruebaOR()
    {
        var compuertaOR = new CompuertaOR("OR");
        compuertaOR.AgregarEntrada(0);
        compuertaOR.AgregarEntrada(1);

        Assert.Equal(1, compuertaOR.Calcular());
    }

    [Fact]
    public void PruebaNOT()
    {
        var compuertaNOT = new CompuertaNOT("NOT");
        compuertaNOT.AgregarEntrada(1);

        Assert.Equal(0, compuertaNOT.Calcular());
    }
}