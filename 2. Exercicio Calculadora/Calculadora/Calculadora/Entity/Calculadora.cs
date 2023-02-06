
namespace Calculadora.Entity;

public class Calculadora : CalculadoraCientifica
{
    public Calculadora()
    {
    }

    public double Soma(double x, double y) {
        return x + y;
    }

    public double Subtracao(double x, double y) { return x - y; }
    public double Divisao(double x, double y) { return x / y; }
    public double Multiplicacao(double x, double y) { return x * y; }
}
