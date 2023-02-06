namespace Lampada;

class Program
{
    public static void Main(string[] args)
    {
        // Criei uma lampada
        Lampada lampadaDeCasa = new Lampada(true);

        lampadaDeCasa.Imprimir();

        lampadaDeCasa.Desligar();

        lampadaDeCasa.Imprimir();

        lampadaDeCasa.Ligar();

        lampadaDeCasa.Imprimir();

    }
}