using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
        MySqlConnection conexao; 
        public Pedidos()
        {
            InitializeComponent();

            listaProd.View = View.Details;
            listaProd.LabelEdit = true;
            listaProd.AllowColumnReorder = true;
            listaProd.FullRowSelect = true;
            listaProd.GridLines = true;

            listaProd.Columns.Add("ID Pedido", 80, HorizontalAlignment.Left);
            listaProd.Columns.Add("ID Usuário", 80, HorizontalAlignment.Left);
            listaProd.Columns.Add("Nome Usuario", 120, HorizontalAlignment.Left);
            listaProd.Columns.Add("ID Produto", 80, HorizontalAlignment.Left);
            listaProd.Columns.Add("Nome Produto", 120, HorizontalAlignment.Left);
            listaProd.Columns.Add("Quantidade", 80, HorizontalAlignment.Left);
            listaProd.Columns.Add("Valor", 70, HorizontalAlignment.Left);
            listaProd.Columns.Add("Data", 140, HorizontalAlignment.Left);
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

        private void Pedidos_Load(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";
                conexao = new MySqlConnection(strConexao);

                string sql = "select pedidos.id, pedidos.usuarioId, usuarios.nome, pedidos.produtoId, produtos.nome ,pedidos.quantidade, pedidos.valorPedido, pedidos.dataPedido " +
                "from pedidos cross join usuarios, produtos " +
                "where pedidos.usuarioId = usuarios.id and produtos.id = pedidos.produtoId";

                MySqlCommand command = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader reader = command.ExecuteReader();

                listaProd.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        Convert.ToString((int)reader.GetInt32(0)),
                        Convert.ToString((int)reader.GetInt32(1)),
                        reader.GetString(2),
                        Convert.ToString((int)reader.GetInt32(3)),
                        reader.GetString(4),
                        Convert.ToString((int)reader.GetInt32(5)),
                        Convert.ToString((decimal)reader.GetDecimal(6)),
                        Convert.ToString((MySqlDateTime)reader.GetMySqlDateTime(7))
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";
                conexao = new MySqlConnection(strConexao);

                string sql = "select pedidos.id, pedidos.usuarioId, usuarios.nome, pedidos.produtoId, produtos.nome ,pedidos.quantidade, pedidos.valorPedido, pedidos.dataPedido " +
                "from pedidos cross join usuarios, produtos " +
                "where pedidos.usuarioId = usuarios.id and produtos.id = pedidos.produtoId and pedidos.id = '" + txtPedido.Text + "'";

                MySqlCommand command = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader reader = command.ExecuteReader();

                listaProd.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        Convert.ToString((int)reader.GetInt32(0)),
                        Convert.ToString((int)reader.GetInt32(1)),
                        reader.GetString(2),
                        Convert.ToString((int)reader.GetInt32(3)),
                        reader.GetString(4),
                        Convert.ToString((int)reader.GetInt32(5)),
                        Convert.ToString((decimal)reader.GetDecimal(6)),
                        Convert.ToString((MySqlDateTime)reader.GetMySqlDateTime(7))
                    }; 

                    var linha_lv = new ListViewItem(row);

                    listaProd.Items.Add(linha_lv);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
