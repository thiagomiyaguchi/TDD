using TDD;

namespace TestesTDD;

public class UnitTest1
{

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();

        int resultado = calc.Somar(val1, val2);

        Assert.Equal(res, resultado);

    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(8, 4, 4)]
    public void TesteSubtrair(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();

        int resultado = calc.Subtrair(val1, val2);

        Assert.Equal(res, resultado);

    }
    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(10, 2, 5)]

    public void TesteDividir(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();

        int resultado = calc.Dividir(val1, val2);

        Assert.Equal(res, resultado);

    }

    [Theory]
    [InlineData(3, 2, 6)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int res)
    {
        Calculadora calc = new Calculadora();

        int resultado = calc.Multiplicar(val1, val2);

        Assert.Equal(res, resultado);

    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = new Calculadora();
        calc.Somar(1, 2);
        calc.Somar(3, 4);
        calc.Somar(5, 6);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}