using NotaFiscalIma.Model;

namespace NotaFiscal
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Deseja iniciar um cliente ? 1 - Sim   |    2 - Não");
            short respostaUsuario = short.Parse(Console.ReadLine());

            if(respostaUsuario == 1)
            {
                Console.Write("\nDigite o nome do cliente: ");
                string nomeCliente = Console.ReadLine();


                Console.Write("\nDigite o CPF do cliente: ");
                string cpfCliente = Console.ReadLine();


                decimal saldoTemporarioCliente = 0;
                decimal saldoTemporarioCliente2 = 100;


                // Instanciando clienteLuis da classe Cliente

                Cliente clienteLuis = new Cliente(nomeCliente,cpfCliente,saldoTemporarioCliente);

                
                
                // Instanciando clienteHugo da classe Cliente que vai ter como saldo 200 R$

                Cliente clienteHugo = new Cliente("Hugo", "000000", saldoTemporarioCliente2);




                // Instanciando um produto - que simula uma tabela de produtos
                Produto tabelaProdutos = new();

                // Instanciando um mouse gamer
                Produto mouseGamer = new Produto("Mouse gamer", "123ID-54", 74);


                // Aqui eu acesso a tabela de produtos, passo o meu cliente como parametro para ver se da pra comprar o produto instanciado
                tabelaProdutos.ComprarProduto(clienteLuis, mouseGamer.NomeProduto, mouseGamer.ValorProduto);


                tabelaProdutos.ComprarProduto(clienteHugo, mouseGamer.NomeProduto, mouseGamer.ValorProduto);

            }
        }
    }
}