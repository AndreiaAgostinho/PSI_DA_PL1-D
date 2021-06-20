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
    
    public partial class GestãoPromotoresTodos : Form
    {
        private DBContainer dBContainer;
        public GestãoPromotoresTodos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            dataGridView_promotores.DataSource = dBContainer.Promotor.ToList<Promotor>();
        }

        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoFuncionarios = new GestaoFuncionariosTodos();
            voltarGestaoFuncionarios.Show();
            this.Hide();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoPareceres = new GestaoParecer();
            voltarGestaoPareceres.Show();
            this.Hide();
        }

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoProcessos = new GestãoProcessosTodos();
            voltarGestaoProcessos.Show();
            this.Hide();
        }

        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoProjetos = new GestãoProjetosTodos();
            voltarGestaoProjetos.Show();
            this.Hide();
        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoPromotores = new MainPage();
            voltarGestaoPromotores.Show();
            this.Hide();
        }
    }
}
