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
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";
                var conexao = new MySqlConnection(strConexao);
                var cmd = conexao.CreateCommand();
                conexao.Open();
                cmd.CommandText = "INSERT INTO produtos(nome, cor, tamanho, valor, marca, qtd_prod)" +
                    " VALUES(@nome, @cor, @tamanho, @valor, @marca, @qtd)";
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNomeProd.Text;
                cmd.Parameters.Add("@cor", MySqlDbType.VarChar).Value = txtCor.Text;
                cmd.Parameters.Add("@tamanho", MySqlDbType.VarChar).Value = txtTamanho.Text;
                cmd.Parameters.Add("@marca", MySqlDbType.VarChar).Value = txtMarca.Text;
                cmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = txtValorProd.Text;
                cmd.Parameters.Add("@qtd", MySqlDbType.Int64).Value = txtQtdProd.Text;
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

        private void Cadastro_Load(object sender, EventArgs e)
        {
            int codigo = 0;
            string valor;
            string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
            try
            {
                MySqlCommand sql = new MySqlCommand("Select MAX(id) From produtos", conexao);
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

        private void btnCadAt_Click(object sender, EventArgs e)
        {

        }

        private void btnConsAt_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.Show();
            this.Hide();
        }

        private void txtCor_Enter(object sender, EventArgs e)
        {
            if (txtCor.Text == "Cor")
            {
                txtCor.Text = "";
                txtCor.ForeColor = Color.Black;
            }
        }

        private void txtCor_Leave(object sender, EventArgs e)
        {
            if (txtCor.Text == "")
            {
                txtCor.Text = "Cor";
                txtCor.ForeColor = Color.DarkGray;
            }
        }

        private void txtTamanho_Leave(object sender, EventArgs e)
        {
            if (txtTamanho.Text == "")
            {
                txtTamanho.Text = "Tamanho";
                txtTamanho.ForeColor = Color.DarkGray;
            }
        }

        private void txtTamanho_Enter(object sender, EventArgs e)
        {
            if (txtTamanho.Text == "Tamanho")
            {
                txtTamanho.Text = "";
                txtTamanho.ForeColor = Color.Black;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.DarkGray;
            }
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Marca")
            {
                txtMarca.Text = "";
                txtMarca.ForeColor = Color.Black;
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }
    }
}
