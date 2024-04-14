namespace TDD;
public class Calculadora
{
    private List<string> listaHistorico;

    public Calculadora()
    {
        listaHistorico = new List<string>();
    }
    public int Somar(int val1, int val2)
    {

        listaHistorico.Insert(0, $"O resultado da soma foi {val1 + val2}");
        return val1 + val2;
    }

    public int Subtrair(int val1, int val2)
    {
        listaHistorico.Insert(0, $"O resultado da subtração foi {val1 - val2}");
        return val1 - val2;
    }
    public int Multiplicar(int val1, int val2)
    {
        listaHistorico.Insert(0, $"O resultado da multiplicação foi {val1 * val2}");
        return val1 * val2;
    }
    public int Dividir(int val1, int val2)
    {
        listaHistorico.Insert(0, $"O resultado da multiplicação foi {val1 / val2}");
        return val1 / val2;
    }

    public List<string> Historico()
    {
        listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
        return listaHistorico;
    }


}
