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
            listaProd.Columns.Add("Quantidade", 150, HorizontalAlignment.Left);
            listaProd.Columns.Add("Valor", 150, HorizontalAlignment.Left);
            listaProd.Columns.Add("Descrição", 300, HorizontalAlignment.Left);
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
                string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
                conexao = new MySqlConnection(strConexao);

                string src = "'%" + txtId.Text + "%'";
                string sql = "select * from produto where id_prod like" + src;

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
                        reader.GetString(4)
                    };


                    var linha_lv = new ListViewItem(row);

                    listaProd.Items.Add(linha_lv);
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var btnclick = true;
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
                conexao = new MySqlConnection(strConexao);

                string src = "'%" + txtId.Text + "%'";
                string sql = "select * from produto where nome_prod like" + src
                    + "or id_prod like" + src
                    + "or desc_prod like" + src;

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
                        reader.GetString(4)
                    };


                    var linha_lv = new ListViewItem(row);

                    listaProd.Items.Add(linha_lv);
                }
                if (btnclick == true)
                {
                    int codigo = 0;
                    string id;
                    string nome;
                    string valor;
                    string qtd;
                    string desc;

                    try
                    {
                        codigo = reader.GetInt32(0);
                        nome = reader.GetString(1);
                        valor = reader.GetString(2);
                        qtd = reader.GetString(3);
                        desc = reader.GetString(4);

                        id = (codigo).ToString();

                        txtId.Text = id;
                        txtId.ForeColor = Color.Black;
                        txtNomeProd.Text = nome;
                        txtNomeProd.ForeColor = Color.Black;
                        txtQtdProd.Text = qtd;
                        txtQtdProd.ForeColor = Color.Black;
                        txtValorProd.Text = valor;
                        txtValorProd.ForeColor = Color.Black;
                        txtDescProd.Text = desc;
                        txtDescProd.ForeColor = Color.Black;
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

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string src =  txtId.Text;
            string nome = "'" + txtNomeProd.Text + "'";
            string qtd = "'" + txtQtdProd.Text + "'";
            string valor = "'" + txtValorProd.Text + "'";
            string desc = "'" + txtDescProd.Text + "'";

            try
            {
                string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
                conexao = new MySqlConnection(strConexao);
                string sql = "UPDATE produto SET nome_prod = " + nome + ", qtd_prod = "+ qtd + ", vl_prod = " + valor + ", desc_prod = " + desc + " WHERE id_prod = " + src;

                MySqlCommand command = new MySqlCommand(sql, conexao);

                conexao.Open();
               
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            conexao.Close();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string src = "'%" + txtId.Text + "%'";

            try
            {
                string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
                conexao = new MySqlConnection(strConexao);
                string sql = "delete from produtos where " + src ;

                MySqlCommand command = new MySqlCommand(sql, conexao);

                conexao.Open();

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
    }
}

