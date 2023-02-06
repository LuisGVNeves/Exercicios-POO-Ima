

namespace FiguraGeometrica.Models;

public class Quadrado : FiguraGeometrica
{
    public double Lado { get; set; }
    public double Area { get; set; }
    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override void CalcularArea()
    {
        Area = Lado * Lado;
    }
}
