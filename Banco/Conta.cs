using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do depósito deve ser positivo.");
            Saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser positivo.");
            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente para saque.");
            Saldo -= valor;
        }

    }
}
