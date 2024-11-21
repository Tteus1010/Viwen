using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjPTCC
{
    public partial class Editar : Form
    {
        MySqlConnection conexao;

        public Editar()
        {
            InitializeComponent();

            listaProd.View = View.Details;
            listaProd.LabelEdit = true;
            listaProd.AllowColumnReorder = true;
            listaProd.FullRowSelect = true;
            listaProd.GridLines = true;

            listaProd.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listaProd.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listaProd.Columns.Add("Cor", 150, HorizontalAlignment.Left);
            listaProd.Columns.Add("Tamanho", 150, HorizontalAlignment.Left);
            listaProd.Columns.Add("Valor", 150, HorizontalAlignment.Left);
            listaProd.Columns.Add("Marca", 150, HorizontalAlignment.Left);
            listaProd.Columns.Add("Quantidade", 150, HorizontalAlignment.Left);
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.Show();
            this.Hide();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";
                conexao = new MySqlConnection(strConexao);

                string src = "'%" + txtId.Text + "%'";
                string sql = "select * from produtos where id like" + src;

                MySqlCommand command = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader reader = command.ExecuteReader();

                listaProd.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        Convert.ToString((int)reader.GetInt32(0)),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        Convert.ToString((decimal)reader.GetDecimal(4)),
                        reader.GetString(5),
                        Convert.ToString((int)reader.GetInt32(6))
                    };


                    var linha_lv = new ListViewItem(row);

                    listaProd.Items.Add(linha_lv);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexao.Close();

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var btnclick = true;
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";
                conexao = new MySqlConnection(strConexao);

                string src = txtId.Text;
                Convert.ToInt32 (src);
                string sql = "select * from produtos where id like " + src;

                MySqlCommand command = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader reader = command.ExecuteReader();

                listaProd.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        Convert.ToString((int)reader.GetInt32(0)),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        Convert.ToString((decimal)reader.GetDecimal(4)),
                        reader.GetString(5),
                        Convert.ToString((int)reader.GetInt32(6)),
                    };


                    var linha_lv = new ListViewItem(row);

                    listaProd.Items.Add(linha_lv);
                }
                if (btnclick == true)
                {
                    int codigo = 0;
                    int qtd = 0;
                    decimal preco = 0;
                    string id;
                    string nome;
                    string valor;
                    string qtd_prod;
                    string cor;
                    string tamanho;
                    string marca;

                    try
                    {
                        codigo = reader.GetInt32(0);
                        nome = reader.GetString(1);
                        cor = reader.GetString(2);
                        tamanho = reader.GetString(3);
                        preco = reader.GetDecimal(4);
                        marca = reader.GetString(5);
                        qtd = reader.GetInt32(6);
                        valor = (preco).ToString();
                        qtd_prod = (qtd).ToString();
                        id = (codigo).ToString();

                        txtId.Text = id;
                        txtId.ForeColor = Color.Black;
                        txtNomeProd.Text = nome;
                        txtNomeProd.ForeColor = Color.Black;
                        txtCor.Text = cor;
                        txtCor.ForeColor = Color.Black;
                        txtTamanho.Text = tamanho;
                        txtTamanho.ForeColor = Color.Black;
                        txtMarca.Text = marca;
                        txtMarca.ForeColor = Color.Black;
                        txtQtdProd.Text = qtd_prod;
                        txtQtdProd.ForeColor = Color.Black;
                        txtValorProd.Text = valor;
                        txtValorProd.ForeColor = Color.Black;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexao.Close();
                        
        }

        //private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string src = txtId.Text;



            try
            {
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";

                var conexao = new MySqlConnection(strConexao);
                var cmd = conexao.CreateCommand();

                conexao.Open();

                cmd.CommandText = "UPDATE produtos SET nome = @nome, cor = @cor, tamanho = @tamanho, valor = @valor, marca = @marca, qtd_prod = @qtd WHERE id = " + src;

                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNomeProd.Text;
                cmd.Parameters.Add("@cor", MySqlDbType.VarChar).Value = txtCor.Text;
                cmd.Parameters.Add("@tamanho", MySqlDbType.VarChar).Value = txtTamanho.Text;
                cmd.Parameters.Add("@marca", MySqlDbType.VarChar).Value = txtMarca.Text;
                cmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = txtValorProd.Text;
                cmd.Parameters.Add("@qtd", MySqlDbType.Int64).Value = txtQtdProd.Text;

                cmd.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Item Atualizado com sucesso!");

                Editar editar = new Editar();
                editar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexao.Close();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string src = txtId.Text;

            try
            {
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";

                var conexao = new MySqlConnection(strConexao);
                var cmd = conexao.CreateCommand();

                conexao.Open();

                cmd.CommandText = "delete from produtos where id = " + src;

                cmd.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Item excluido com sucesso!");

                Editar editar = new Editar();
                editar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexao.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtNomeProd_Leave(object sender, EventArgs e)
        {
            if (txtNomeProd.Text == "")
            {
                txtNomeProd.Text = "Nome do Produto";
                txtNomeProd.ForeColor = Color.DarkGray;
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

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.DarkGray;
            }
        }

        private void txtQtdProd_Leave(object sender, EventArgs e)
        {
            if (txtQtdProd.Text == "")
            {
                txtQtdProd.Text = "Quantidade";
                txtQtdProd.ForeColor = Color.DarkGray;
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

        private void txtNomeProd_Enter(object sender, EventArgs e)
        {
            if (txtNomeProd.Text == "Nome do Produto")
            {
                txtNomeProd.Text = "";
                txtNomeProd.ForeColor = Color.Black;
            }
        }

        private void txtCor_Enter(object sender, EventArgs e)
        {
            if (txtCor.Text == "Cor")
            {
                txtCor.Text = "";
                txtCor.ForeColor = Color.Black;
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

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Marca")
            {
                txtMarca.Text = "";
                txtMarca.ForeColor = Color.Black;
            }
        }

        private void txtQtdProd_Enter(object sender, EventArgs e)
        {
            if (txtQtdProd.Text == "Quantidade")
            {
                txtQtdProd.Text = "";
                txtQtdProd.ForeColor = Color.Black;
            }
        }

        private void txtValorProd_Enter(object sender, EventArgs e)
        {
            if (txtValorProd.Text == "Valor")
            {
                txtValorProd.Text = "";
                txtValorProd.ForeColor = Color.Black;
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();

        }
    }
}

