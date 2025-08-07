using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_OO
{
    public class ContaCorrente : ContaGenerica
    {
        public ContaCorrente(string? banco, string? agencia, string? conta, decimal saldoInicial, decimal limite) : base(banco, agencia, conta, saldoInicial)
        {
            this.Limite = limite;
        }
        public decimal Limite { get; set; }
    }
}
