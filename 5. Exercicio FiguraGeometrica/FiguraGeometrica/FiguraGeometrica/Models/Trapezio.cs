
namespace FiguraGeometrica.Models;

public class Trapezio : FiguraGeometrica
{
    public double BaseMaior { get; set; }
    public double BaseMenor { get; set; }
    public double Altura { get; set; }
    public double Area { get; set; }

    public Trapezio(double baseMaior, double baseMenor, double altura)
    {
        BaseMaior = baseMaior;
        BaseMenor = baseMenor;
        Altura = altura;
    }

    public override void CalcularArea()
    {
        Area = ((BaseMaior + BaseMenor) * Altura / 2);
    }
}
