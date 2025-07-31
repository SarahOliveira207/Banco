using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public Funcionario(int id, string nome, string cargo, decimal salario)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }
        public void AumentarSalario(decimal percentual)
        {
            if (percentual <= 0)
                throw new ArgumentException("O percentual deve ser positivo.");
            Salario += Salario * percentual / 100;
        }
    }
}

