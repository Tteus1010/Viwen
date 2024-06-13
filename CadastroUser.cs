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
    public partial class CadastroUser : Form
    {
        public CadastroUser()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.Show();
            this.Hide();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=12345678; database=viwen";
                var conexao = new MySqlConnection(strConexao);
                var cmd = conexao.CreateCommand();
                conexao.Open();
                cmd.CommandText = "INSERT INTO login(login_user,senha_user) VALUES(?login,?senha)";
                cmd.Parameters.Add("?login", MySqlDbType.VarChar).Value = txtLoginCad.Text;
                cmd.Parameters.Add("?senha", MySqlDbType.VarChar).Value = txtSenhaCad.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastro realizado com sucesso");
                telaLogin login = new telaLogin();
                login.Show();
                this.Hide();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }

        }
        private void txtLoginCad_Enter(object sender, EventArgs e)
        {
            if (txtLoginCad.Text == "Nome Usuário")
            {
                txtLoginCad.Text = "";
                txtLoginCad.ForeColor = Color.Black;
            }
        }

        private void txtLoginCad_Leave(object sender, EventArgs e)
        {
            if (txtLoginCad.Text == "")
            {
                txtLoginCad.Text = "Nome Completo";
                txtLoginCad.ForeColor = Color.DarkGray;
            }
        }

        private void txtSenhaCad_Enter(object sender, EventArgs e)
        {
            if (txtSenhaCad.Text == "Senha")
            {
                txtSenhaCad.Text = "";
                txtSenhaCad.UseSystemPasswordChar = true;
                txtSenhaCad.ForeColor = Color.Black;
            }
        }

        private void txtSenhaCad_Leave(object sender, EventArgs e)
        {
            if (txtSenhaCad.Text == "")
            {
                txtSenhaCad.Text = "Senha";
                txtSenhaCad.UseSystemPasswordChar = false;
                txtSenhaCad.ForeColor = Color.DarkGray;
            }
        }

        private void CadastroUser_Load(object sender, EventArgs e)
        {

        }
    }
}