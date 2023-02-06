using FiguraGeometrica.Models;

namespace Principal;

class Program
{
    public static void Main(string[] args)
    {
        Trapezio trapezio = new Trapezio(5, 6, 15);
        Quadrado quadrado = new Quadrado(5);
        Triangulo triangulo = new Triangulo(5,5);

        // Método para calcular a area do trapezio
        trapezio.CalcularArea();

        // Método para calcular a area do quadrado
        quadrado.CalcularArea();

        // Método para calcular a area do triangulo
        triangulo.CalcularArea();
        
        Console.WriteLine(trapezio.Area);
        Console.WriteLine(quadrado.Area);
        Console.WriteLine(triangulo.Area);
    }
}