using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjPTCC
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtPedido.Text == "")
            {
                txtPedido.Text = "Número do Pedido";
                txtPedido.ForeColor = Color.DarkGray;
            }

        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtPedido.Text == "Número do Pedido")
            {
                txtPedido.Text = "";
                txtPedido.ForeColor = Color.Black;
            }
            
        }
    }
}
