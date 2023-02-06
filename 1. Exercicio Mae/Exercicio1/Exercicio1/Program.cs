using Exercicio1.Entity;

namespace Principal;

class Program
{
    public static void Main(string[] args)
    {
        // Instanciando objeto primeiraMae da classe Mae

        Mae primeiraMae = new Mae("Naby",37,"07/05/1980",1.57);

        // Apresentação da mãe
        primeiraMae.Apresentar();

        // Incrementar a idade da mãe em 3x fazendo aniversário
        primeiraMae.FazerAniversario();
        primeiraMae.FazerAniversario();
        primeiraMae.FazerAniversario();


        // Adicionar um sobrenome a Mãe
        primeiraMae.SetNameMae("Naby", "Trilos");


        // Apresentação da mãe
        primeiraMae.Apresentar();
    }
}