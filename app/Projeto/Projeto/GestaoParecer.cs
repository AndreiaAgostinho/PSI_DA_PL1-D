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
    public partial class GestaoParecer : Form
    {
        private DBContainer dBContainer;
        public GestaoParecer()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            combo_funcionario.DataSource = dBContainer.Funcionario.ToList<Funcionario>();
            combobox_projeto_associado.DataSource = dBContainer.ProjetoSet.ToList<Projeto>();

        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoPareceres = new MainPage();
            voltarGestaoPareceres.Show();
            this.Hide();
        }

        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoFuncionariosButao = new GestaoFuncionariosTodos();
            gestaoFuncionariosButao.Show();
            this.Hide();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPareceresButao = new GestaoParecer();
            gestaoPareceresButao.Show();
            this.Hide();
        }

        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProjetosButao = new GestaoProjeto();
            gestaoProjetosButao.Show();
            this.Hide();
        }

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestaoProcesso();
            gestaoProcessosButao.Show();
            this.Hide();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestaoPromotore();
            gestaoPromotoresButao.Show();
            this.Hide();
        }

        private void combo_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parecer parecer = new Parecer();
            //parecer.Funcionario = combo_funcionario;
            parecer.DataParecer = datapicker_parecer.Value.ToString();
            parecer.TextoParecer = tb_observacoes.Text;
            dBContainer.ParecerSet.Add(parecer);
            dBContainer.SaveChanges();
        }
    }
}
