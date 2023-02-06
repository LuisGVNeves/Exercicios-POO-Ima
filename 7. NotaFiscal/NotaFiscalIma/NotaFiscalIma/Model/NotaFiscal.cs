using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscalIma.Model
{
    public class NotaFiscal
    {

        protected void GerarNotaFiscal()
        {
            Guid g = Guid.NewGuid();
            Console.WriteLine(g.ToString());
            Console.ReadLine();
        }

        protected void MostrarNotaFiscal(string nomeProduto, decimal valorProduto)
        {
            Console.WriteLine("\n\n");

            Random numeroAleatorio = new Random();
            
            Console.WriteLine($"Nota fiscal: {numeroAleatorio.Next()}");
            Console.WriteLine($"Nome do produto: {nomeProduto}");
            Console.WriteLine($"Valor do produto: {valorProduto}");

            GerarNotaFiscal();
        }
    }
}
