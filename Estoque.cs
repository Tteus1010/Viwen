using MySql.Data.MySqlClient;
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
    public partial class Estoque : Form
    {


        MySqlConnection conexao;

        public Estoque()
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.Show();
            this.Hide();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
                conexao = new MySqlConnection(strConexao);

                string src = "'%" + txtPesquisa.Text + "%'";
                string sql = "select * from produto where nome_prod like" + src;

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
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
                conexao = new MySqlConnection(strConexao);                           

                string src = "'%" + txtPesquisa.Text + "%'";
                string sql = "select * from produto where nome_prod like" + src 
                    +"or id_prod like" + src 
                    +"or desc_prod like" + src;

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
    }
}
