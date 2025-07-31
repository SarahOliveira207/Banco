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
        public decimal Saldo
        {
            get { return Saldo; }
            set { saldo = value; }
        }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor;
            //contadorConta++;
        }
        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

    }
}
