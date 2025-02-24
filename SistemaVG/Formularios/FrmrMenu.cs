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

namespace SistemaVG.Formularios
{
    public partial class FrmrMenu : Form
    {
        public FrmrMenu()
        {
            InitializeComponent();
        }

        
        private void FrmrMenu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            var cadastro = new Fmrcadastro();
            cadastro.Show();

            this.Visible = false;
        }

        private void Btn_entrar_Click(object sender, EventArgs e)
        {

            string usuario = txtusuario.Text;
            string senha = txtsenha.Text;

            // Verificar se os campos não estão vazios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Se algum campo estiver vazio, não faz a consulta
            }

            // String de conexão com o banco de dados
            string conexaoString = "Server=localhost;Port=3306;Database=sistemavg;Uid=root;Pwd=";

            // SQL de verificação do usuário e senha
            string sql = "SELECT COUNT(*) FROM svg_usuario WHERE usuario = @usuario AND senha = @senha";

            try
            {
                // Criar a conexão com o banco de dados
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    // Criar o comando de SQL
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@senha", senha);

                    // Abrir a conexão
                    conexao.Open();

                    // Executar a consulta e verificar se o usuário existe
                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count > 0)
                    {
                        // Usuário e senha encontrados no banco
                        MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Aqui você pode abrir a próxima tela ou o formulário principal
                        // Exemplo: Abrir o Formulário de Cadastro

                        var sistema = new FrmrSistema();
                        sistema.Show();
                        this.Visible = false;

                    }
                    else
                    {
                        // Usuário ou senha inválidos
                        MessageBox.Show("Usuário ou senha inválidos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibir mensagem de erro
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmrMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

 
