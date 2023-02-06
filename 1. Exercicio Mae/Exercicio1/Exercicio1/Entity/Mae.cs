
namespace Exercicio1.Entity;

public class Mae
{
    // Atributos
    private string nome;
    private int idade;
    private string dataNascimento;
    private double altura;

    // Construtor
    public Mae(string nome, int idade, string dataNascimento, double altura)
    {
        // this referencia aos atributos da classe, para distinguir entre parâmetro do construtor e atributos
        this.nome = nome;
        this.idade = idade;
        this.dataNascimento = dataNascimento;
        this.altura = altura;
    }

    // Getters e Setters
    public string GetNameMae()
    {
        return nome;
    }


    // Sobrenome recebe vazio por padrão
    public void SetNameMae(string nomeMae, string sobrenome = "")
    {
        nome = nomeMae + " " + sobrenome;
    }

    public int GetIdadeMae()
    {
        return idade;
    }

    public void FazerAniversario()
    {
        idade++;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá eu sou a {nome} eu nasci em {dataNascimento}, tenho {idade} anos. Atualmente tenho {altura} de altura");
    }
}
