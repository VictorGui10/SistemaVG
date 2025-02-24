using SistemaVG.Relatorios;
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
    public partial class FrmrSistema : Form
    {
        public FrmrSistema()
        {
            InitializeComponent();
        }

        private void FrmrSistema_Load(object sender, EventArgs e)
        {

        }

        private void FrmrSistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void usuariosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var relusuario = new Relusuarios();
            relusuario.Show();

            this.Visible = false;

        }
    }
}
