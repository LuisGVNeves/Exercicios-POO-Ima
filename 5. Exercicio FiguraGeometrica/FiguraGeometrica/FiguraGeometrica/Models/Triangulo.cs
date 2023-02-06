namespace FiguraGeometrica.Models;

public class Triangulo : FiguraGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area { get; set; }

    public Triangulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    public override void CalcularArea()
    {
        Area = (Base * Altura) / 2;
    }
}
