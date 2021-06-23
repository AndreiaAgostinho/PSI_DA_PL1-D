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
    public partial class GestaoProjeto : Form
    {
        private DBContainer dBContainer;
        public GestaoProjeto()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            lb_projetos.DataSource = dBContainer.ProjetoSet.ToList<Projeto>();
            comboBox_documento_projeto.DataSource = dBContainer.Documento.ToList<Documento>();
            comboBox_funcionario_projeto.DataSource = dBContainer.Funcionario.ToList<Funcionario>();
            comboBox_tipo_projeto.DataSource = dBContainer.TipoProjeto.ToList<TipoProjeto>();
        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoProjetos = new MainPage();
            voltarGestaoProjetos.Show();
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

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestaoProcesso();
            gestaoProcessosButao.Show();
            this.Hide();
        }

        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProjetosButao = new GestaoProjeto();
            gestaoProjetosButao.Show();
            this.Hide();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestaoPromotore();
            gestaoPromotoresButao.Show();
            this.Hide();
        }

        private void bt_guardar_projeto_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto();
            projeto.DataEntrega = dateTimePicker_projetos.Value;
            projeto.TipoProjetoId = comboBox_tipo_projeto.SelectedIndex;
            Documento documento = new Documento();
            documento.ProjetoId = comboBox_documento_projeto.SelectedIndex;
            dBContainer.ProjetoSet.Add(projeto);
            dBContainer.Documento.Add(documento);
            dBContainer.SaveChanges();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var documentos = new GestãoDocumentos();
            documentos.Show();
            this.Hide();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestaoPromotore();
            gestaoPromotoresButao.Show();
            this.Hide();
        }

        private void alteraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestaoProcesso();
            gestaoProcessosButao.Show();
            this.Hide();
        }
    }
}
