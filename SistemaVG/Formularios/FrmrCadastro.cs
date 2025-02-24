using MySql.Data.MySqlClient;
using SistemaVG.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVG
{
    public partial class Fmrcadastro : Form
    {
        string nome;
        string cpf;
        string email;
        string datanasc;
        string usuario;
        string senha;


        public Fmrcadastro()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txbnome.Text = " ";
            txbcpf.Text = "";
            txbemail.Text = "";
            txbdatanasc.Text = "";
            txbusuario.Text = "";
            txbsenha.Text = "";


        }

       /* private void btnConectar_Click(object sender, EventArgs e)
        {
            {
                string conexaoString = "Server=localhost;Port=3306;Database=sistemavg;Uid=root;Pwd=";

                try
                {
                    MySqlConnection conexao = new MySqlConnection(conexaoString);
                    conexao.Open();
                    MessageBox.Show("Conexão bem-sucedida!");
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão: " + ex.Message);
                }
            }  --utilizei para ver se a conexao com o banco foi certo
        }*/

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string nome = txbnome.Text;
            string cpf = txbcpf.Text;
            string email = txbemail.Text;
            string dt_nasc = txbdatanasc.Text;
            string usuario = txbusuario.Text;
            string senha = txbsenha.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(dt_nasc) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Se algum campo estiver vazio, não executa a inserção
            }

            string conexaoString = "Server=localhost;Port=3306;Database=sistemavg;Uid=root;Pwd=";  //conexao com o banco

            string sql = "INSERT INTO svg_usuario (nomecompleto,cpf, email,dt_nasc,usuario,senha) VALUES (@nome, @cpf, @email, @dt_nasc, @usuario, @senha)";

            try
            {
                // Criar a conexão com o banco
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    // Criar o comando de SQL
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@cpf",cpf);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("dt_nasc",dt_nasc);
                    comando.Parameters.AddWithValue("usuario", usuario);
                    comando.Parameters.AddWithValue("senha",senha);

                    // Abrir a conexão
                    conexao.Open();

                    // Executar o comando SQL
                    comando.ExecuteNonQuery();

                    // Mostrar mensagem de sucesso
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                // Exibir mensagem de erro
                MessageBox.Show("Erro ao inserir dados: " + ex.Message);
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            var menu = new FrmrMenu();
            menu.Show();

            this.Visible = false;
        }

        private void Fmrcadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
    
