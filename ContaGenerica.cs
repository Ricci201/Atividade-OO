
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Atividade_OO
{
    public class ContaGenerica
    {
        public string? Banco { get; private set; }
        public string? Agencia { get; private set; }
        public string? Conta { get; private set; }
        public decimal Saldo { get; protected set; }

        public ContaGenerica(string? banco, string? agencia, string? conta, decimal saldoInicial)
        {
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor inválido para depósito.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido.");
            }
        }

        internal virtual void Exibir()
        {
            Console.WriteLine($"Banco: {Banco}\nAgência: {Agencia}\nConta: {Conta}\nSaldo: {Saldo:C}");
        }
    }
}