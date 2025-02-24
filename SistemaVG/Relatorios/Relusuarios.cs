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

namespace SistemaVG.Relatorios
{
    public partial class Relusuarios : Form
    {

        string conexaoString = "Server=localhost;Port=3306;Database=sistemavg;Uid=root;Pwd=";
        public Relusuarios()
        {
            InitializeComponent();
        }

        private void CarregarUsuarios()

        {

            {
                // Criar a consulta SQL
                string query = "SELECT id, nome, email FROM svg_usuario";

                try
                {
                    // Criar a conexão com o banco
                    using (MySqlConnection conn = new MySqlConnection(conexaoString))
                    {
                        // Abrir a conexão
                        conn.Open();

                        // Criar o comando MySQL
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        // Criar o adaptador de dados
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        // Criar um DataTable para armazenar os resultados
                        DataTable dt = new DataTable();

                        // Preencher o DataTable com os dados
                        adapter.Fill(dt);

                        // Definir o DataSource do DataGridView como o DataTable
                        dgvUsuarios.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro caso ocorra algum problema
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }

            }
        }

            private void Relusuarios_Load(object sender, EventArgs e) {

            CarregarUsuarios();

        }

    }
}
