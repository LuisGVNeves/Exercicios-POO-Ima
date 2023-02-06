
namespace Lampada;
public class Lampada
{
    // Lampada ligada
    private bool ligado;

    // Construtor
    public Lampada(bool ligado)
    {
        this.ligado = ligado;
    }


    // @ Propriedade para alterar a lampada
    /*public bool Ligado
    {
        get { return ligado; }
        set { ligado = value; }
    }
    */

    public void Ligar()
    {
        ligado = true;
    }

    public void Desligar()
    {
        ligado = false;
    }

    public void Imprimir()
    {
        if (ligado == true) 
        { 
            Console.WriteLine("Lâmpada Ligada"); 
        }
        else
        {
            Console.WriteLine("Lâmpada Desligada");
        }
    }

}
