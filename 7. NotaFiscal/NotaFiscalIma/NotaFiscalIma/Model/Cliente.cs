using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscalIma.Model
{
    public class Cliente
    {
        // Propriedades do cliente
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public decimal SaldoCliente { get; set; }

        // Construtor
        public Cliente(string nomeCliente, string cpfCliente, decimal saldoCliente)
        {
            NomeCliente = nomeCliente;
            CpfCliente = cpfCliente;
            SaldoCliente = saldoCliente;
        }
    }
}
