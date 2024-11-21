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
            this.Hide();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost; uid=root; pwd=123456789; database=viewen_db";
                var conexao = new MySqlConnection(strConexao);
                var cmd = conexao.CreateCommand();
                conexao.Open();
                cmd.CommandText = "INSERT INTO usuarios(nome,email,senha) VALUES(@nome,@login,@senha)";
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = txtLoginCad.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenhaCad.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastro realizado com sucesso");
                this.Hide();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }

        }
        private void txtLoginCad_Enter(object sender, EventArgs e)
        {
            if (txtLoginCad.Text == "Insira o E-mail")
            {
                txtLoginCad.Text = "";
                txtLoginCad.ForeColor = Color.Black;
            }
        }

        private void txtLoginCad_Leave(object sender, EventArgs e)
        {
            if (txtLoginCad.Text == "")
            {
                txtLoginCad.Text = "Insira o E-mail";
                txtLoginCad.ForeColor = Color.DarkGray;
            }
        }

        private void txtSenhaCad_Enter(object sender, EventArgs e)
        {
            if (txtSenhaCad.Text == "Insira a Senha")
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
                txtSenhaCad.Text = "Insira a Senha";
                txtSenhaCad.UseSystemPasswordChar = false;
                txtSenhaCad.ForeColor = Color.DarkGray;
            }
        }

        private void CadastroUser_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Insira o Nome Completo")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Insira o Nome Completo";
                txtNome.ForeColor = Color.DarkGray;
            }
        }
    }
}