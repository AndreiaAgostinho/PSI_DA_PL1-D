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
    public partial class GestaoFuncionariosTodos : Form
    {
        private DBContainer dBContainer;
        //Inicializa o datagridview e o dbcontainer com o seu datasource
        public GestaoFuncionariosTodos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
           dataGridView_funcionarios.DataSource = dBContainer.Funcionario.ToList<Funcionario>();
        }

        private void GestaoFuncionariosInicial_Load(object sender, EventArgs e)
        {

        }
        //botão em toolstrip para voltar ao gestao de funcionarios
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registroFuncionario = new GestãoFuncionario();
            registroFuncionario.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao menu iniciar
        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarRegistroFuncionario = new MainPage();
            voltarRegistroFuncionario.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de funcionarios(grelha)
        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoFuncionariosButao = new GestaoFuncionariosTodos();
            gestaoFuncionariosButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de pareceres
        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPareceresButao = new GestaoParecer();
            gestaoPareceresButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de processos
        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestaoProcesso();
            gestaoProcessosButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de projetos
        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProjetosButao = new GestaoProjeto();
            gestaoProjetosButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de promotores
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestaoPromotore();
            gestaoPromotoresButao.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loadfuncionariosregistro = new GestãoFuncionario();
            loadfuncionariosregistro.Show();
            this.Hide();
        }
    }
}
