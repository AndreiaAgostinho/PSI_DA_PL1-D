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
    public partial class GestaoFuncionariosInicial : Form
    {
        public GestaoFuncionariosInicial()
        {
            InitializeComponent();
        }

        private void GestaoFuncionariosInicial_Load(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registroFuncionario = new RegistroFuncionario();
            registroFuncionario.Show();
            this.Hide();
        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarRegistroFuncionario = new MainPage();
            voltarRegistroFuncionario.Show();
            this.Hide();
        }

        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoFuncionariosButao = new GestaoFuncionariosInicial();
            gestaoFuncionariosButao.Show();
            this.Hide();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPareceresButao = new GestaoPareceres();
            gestaoPareceresButao.Show();
            this.Hide();
        }

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestaoProcessosInicial();
            gestaoProcessosButao.Show();
            this.Hide();
        }

        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProjetosButao = new GestaoProjetosInicial();
            gestaoProjetosButao.Show();
            this.Hide();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestaoPromotoresInicial();
            gestaoPromotoresButao.Show();
            this.Hide();
        }

        private void alteraçãoDeDadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var alteracaodadosButao = new AlteracaoDadosFuncionarios();
            alteracaodadosButao.Show();
            this.Hide();
        }
    }
}
