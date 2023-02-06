
namespace ExercicioCalculadora;

using Calculadora.Entity;

class Program
{
    public static void Main(string[] args)
    {

        // Instanciar Objeto calculadora
        Calculadora calculadora = new Calculadora();


        // Instanciar objeto calculadora cientifica
        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();


        // Calculadora por fazer herança com calculadora cientifica, consegue ter acesso a + metodos do que a calculadora cientifica
        Console.WriteLine(calculadora.Soma(5,6));
        Console.WriteLine(calculadora.Subtracao(5,6));
        Console.WriteLine(calculadora.Divisao(5,6));
        Console.WriteLine(calculadora.Multiplicacao(5,6));
        Console.WriteLine(calculadora.RaizQuadrada(6));
        Console.WriteLine(calculadora.Potencia(5,6));

        // Calculadora cientifica só tem acesso aos métodos internos dela mesmo
        Console.WriteLine(calculadoraCientifica.RaizQuadrada(8));
        Console.WriteLine(calculadoraCientifica.Potencia(5, 6));
    }
}