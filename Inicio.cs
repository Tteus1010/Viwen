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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.Show();
            this.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
            this.Hide();
        }

        private void btnCadAt_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void btnConsAt_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroUser cadastro = new CadastroUser();
            cadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
        }
    }
}
