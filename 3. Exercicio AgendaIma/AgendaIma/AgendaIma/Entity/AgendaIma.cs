using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace AgendaIma.Entity;

public class AgendaIma
{
    // Lista para guardar dados do tipo Pessoas
    List<Pessoa> listaPessoas = new List<Pessoa>();

    // # Método armazenar pessoa
    public void ArmazenarPessoaNaAgenda(Pessoa pessoa)
    {
        listaPessoas.Add(pessoa);
    }

    // # Método remover pessoa
    public void RemoverPessoaDaAgenda(string nome)
    {
        for (int i = 0; i < listaPessoas.Count(); i++)
        {
            if (listaPessoas[i].Nome == nome)
            {
                listaPessoas.RemoveAt(i);
            }
        }
    }

    // # Método que busca pessoa na agenda
    public void BuscarPessoaNaAgenda(string nome)
    {
        for (int i = 0; i < listaPessoas.Count(); i++)
        {
            if (listaPessoas[i].Nome == nome)
            {
                Console.WriteLine($"{listaPessoas[i].Nome}  Posição na lista: {i}");
            }
        }
  
    }

    // # Método que mostra quantas pessoas tem na agenda
    public void ImprimirAgenda()
    {
        Console.WriteLine("\n-------------- LISTA DE PESSOAS NA AGENDA --------------\n");
        foreach (Pessoa pessoas in listaPessoas)
        {
            Console.WriteLine($"{pessoas.Nome}");
        }
        Console.WriteLine("\n\n");
    }

    public void ImprimirPessoa(string nome)
    {
        Console.WriteLine($"\n-------------- Dados de: {nome} --------------\n");
        foreach (Pessoa pessoa in listaPessoas)
        {
            if(pessoa.Nome == nome)
            {
                Console.WriteLine($"{pessoa.Nome}");
                Console.WriteLine($"{pessoa.Idade}");
            }
        }
    }
}
