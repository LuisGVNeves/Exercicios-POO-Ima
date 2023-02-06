using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscalIma.Model
{
    // Herança pra eu utilizar o método de gerar a nota fiscal da classe nota fiscal
    public class Produto : NotaFiscal
    {
        // Propriedades do produto
        public string NomeProduto { get; set; }
        public string IdProduto { get; set; }
        public decimal ValorProduto { get; set; }

        public Produto() { }


        // Construtor do Produto personalizado
        public Produto(string nomeProduto, string idProduto, decimal valorProduto)
        {
            NomeProduto = nomeProduto;
            IdProduto = idProduto;
            ValorProduto = valorProduto;
        }


        // Métodos da classe Produto
        public void ComprarProduto(Cliente cliente, string nomeProduto, decimal valorProduto)
        {
            // Se o saldo do cliente for maior que o valor do produto, da pra comprar o produto.
            if(cliente.SaldoCliente > valorProduto)
            {
                // O cliente vai comprar o produto e gera uma nota Fiscal
                MostrarNotaFiscal(nomeProduto, valorProduto);
            }

            Console.WriteLine($"Saldo usuário não da pra comprar o produto {nomeProduto}");

        }


    }
}
