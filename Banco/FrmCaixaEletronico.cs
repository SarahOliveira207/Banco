using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FrmCaixaEletronico : Form
    {
        Conta conta = new Conta();
        private decimal valorSaque;
        public FrmCaixaEletronico() //metodo construtor da classe
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            conta.Sacar(valor:numericValorSaque.Value);
            lblSaldo.Text = conta.Saldo.ToString("C2");
        }
    }
}
