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
    public partial class GestãoProjetosTodos : Form
    {
        private DBContainer dBContainer;
        public GestãoProjetosTodos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
        }

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var processos = new GestãoProcessosTodos();
            processos.Show();
            this.Hide();
        }

        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var funcionario = new GestaoFuncionariosTodos();
            funcionario.Show();
            this.Hide();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parecer = new GestaoParecer();
            parecer.Show();
            this.Hide();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var promotor = new GestãoPromotoresTodos();
            promotor.Show();
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
