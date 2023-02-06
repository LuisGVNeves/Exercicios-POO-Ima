namespace Principal;

using Funcionario.Entity;

class Program
{
    public static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario("Maria", "Cecilia", -5);

        // Retorna zero, porque não posso criar com numeros negativos
        Console.WriteLine(funcionario1.SalarioMensal);

        Console.WriteLine($"Nome do funcionario: {funcionario1.Nome} {funcionario1.Sobrenome}, salário mensal: {funcionario1.SalarioMensal} R$");



        Funcionario funcionario2 = new Funcionario("Luis", "Guilherme", 3200);

        Console.WriteLine($"Nome do funcionario: {funcionario2.Nome} {funcionario2.Sobrenome}, salário mensal: {funcionario2.SalarioMensal} R$");


        // Aumento de 20%
        funcionario1.SalarioMensal = ((funcionario1.SalarioMensal * 0.2) + funcionario1.SalarioMensal);
        funcionario2.SalarioMensal = ((funcionario2.SalarioMensal * 0.2) + funcionario2.SalarioMensal);


        Console.WriteLine($"\nSalario anual do funcionario 1: {funcionario1.SalarioMensal * 12}");
        Console.WriteLine($"\nSalario anual do funcionario 2: {funcionario2.SalarioMensal * 12}");

    }
}