using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjPTCC
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Close();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.Show();
            this.Close();
        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
                var conexao = new MySqlConnection(strConexao);
                var cmd = conexao.CreateCommand();
                conexao.Open();
                cmd.CommandText = "INSERT INTO produto(nome_prod, qtd_prod, vl_prod, desc_prod) VALUES(?nome, ?qtd, ?valor, ?desc)";
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = txtNomeProd.Text;
                cmd.Parameters.Add("?valor", MySqlDbType.VarChar).Value = txtValorProd.Text;
                cmd.Parameters.Add("?qtd", MySqlDbType.VarChar).Value = txtQtdProd.Text;
                cmd.Parameters.Add("?desc", MySqlDbType.VarChar).Value = txtDescProd.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Item Cadastrado com sucesso!");
                Cadastro cadastro = new Cadastro();
                cadastro.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {

        }
        private void txtNomeProd_Enter(object sender, EventArgs e)
        {
            if(txtNomeProd.Text == "Nome do Produto")
            {
                txtNomeProd.Text = "";
                txtNomeProd.ForeColor = Color.Black;
            }
        }

        private void txtNomeProd_Leave(object sender, EventArgs e)
        {
            if(txtNomeProd.Text == "")
            {
                txtNomeProd.Text = "Nome do Produto";
                txtNomeProd.ForeColor = Color.DarkGray;
            }
        }

        private void txtQtdProd_Enter(object sender, EventArgs e)
        {
            if(txtQtdProd.Text == "Quantidade")
            {
                txtQtdProd.Text = "";
                txtQtdProd.ForeColor = Color.Black;
            }
        }

        private void txtQtdProd_Leave(object sender, EventArgs e)
        {
            if(txtQtdProd.Text == "")
            {
                txtQtdProd.Text = "Quantidade";
                txtQtdProd.ForeColor = Color.DarkGray;
            }
        }

        private void txtValorProd_Enter(object sender, EventArgs e)
        {
            if(txtValorProd.Text == "Valor")
            {
                txtValorProd.Text = "";
                txtValorProd.ForeColor = Color.Black;
            }
        }

        private void txtValorProd_Leave(object sender, EventArgs e)
        {
            if (txtValorProd.Text == "")
            {
                txtValorProd.Text = "Valor";
                txtValorProd.ForeColor = Color.DarkGray;
            }
        }

        private void txtDescProd_Enter(object sender, EventArgs e)
        {
           if(txtDescProd.Text == "Descrição")
            {
                txtDescProd.Text = "";
                txtDescProd.ForeColor = Color.Black;
            }
        }

        private void txtDescProd_Leave(object sender, EventArgs e)
        {
            if(txtDescProd.Text == "")
            {
                txtDescProd.Text = "Descrição";
                txtDescProd.ForeColor = Color.DarkGray;
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            int codigo = 0;
            string valor;
            string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
            try
            {
                MySqlCommand sql = new MySqlCommand("Select MAX(id_prod) From produto", conexao);
                codigo = (int)sql.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            valor = (codigo + 1).ToString();

            txtId.Text = valor;
            txtId.ForeColor = Color.Black;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.Show();
            this.Hide();
        }
    }
}
