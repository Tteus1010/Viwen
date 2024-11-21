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
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }
        private void telaLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroUser cadastro = new CadastroUser();
            cadastro.Show();
            this.Hide();
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Login")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.Black;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Login";
                txtLogin.ForeColor = Color.DarkGray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = true;
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.ForeColor = Color.DarkGray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "123")
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
            }
            else
            {
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";
                var conexao = new MySqlConnection(strConexao);
                var command = conexao.CreateCommand();
                MySqlCommand query = new MySqlCommand("select * from usuarios where email = '" + txtLogin.Text + "' and senha = '" + txtSenha.Text + "' ", conexao);
                conexao.Open();
                DataTable datatable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(datatable);
                var testwastrue = false;

                foreach (DataRow list in datatable.Rows)
                {
                    if (Convert.ToString(list.ItemArray[3]) == txtSenha.Text || Convert.ToString(list.ItemArray[2]) == txtLogin.Text)
                    {
                        Inicio inicio = new Inicio();
                        inicio.Show();
                        this.Hide();
                        testwastrue = true;
                    }


                    conexao.Close();

                }
                if (!testwastrue)
                {
                    string msgbox = "Usuário Invalido";
                    MessageBox.Show(msgbox);
                }
            }
        }
    }
}