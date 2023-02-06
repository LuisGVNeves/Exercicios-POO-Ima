
namespace Funcionario.Entity;

public class Funcionario
{
    private string nome;
    private string sobrenome;
    private double salarioMensal;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Sobrenome
    {
        get { return sobrenome; }
        set { sobrenome = value; }
    }
    public double SalarioMensal
    {
        get { return salarioMensal; }
        set
        {
            if (value < 0)
            {
                salarioMensal = 0;
                return;
            }
            salarioMensal = value;
        }
    }

    public Funcionario(string nome, string sobrenome, double salarioMensal)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        SalarioMensal = salarioMensal;
    }
}
