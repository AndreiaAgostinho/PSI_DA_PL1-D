using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class GestãoProcessosTodos : Form
    {
        private DBContainer dBContainer;
        public GestãoProcessosTodos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
        }

        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var funcionarios = new GestaoFuncionariosTodos();
            funcionarios.Show();
            this.Hide();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pareceres = new GestaoParecer();
            pareceres.Show();
            this.Hide();
        }


        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Projetos = new GestãoProjetosTodos();
            Projetos.Show();
            this.Hide();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var promotores = new GestãoPromotoresTodos();
            promotores.Show();
            this.Hide();
        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new MainPage();
            menu.Show();
            this.Hide();
        }
    }
}
