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
            fillCells();
        }

       
        //botão em toolstrip para voltar ao gestao de funcionarios
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registroFuncionario = new GestãoFuncionario();
            registroFuncionario.Show();
            this.Close();
        }
        //botão em toolstrip para voltar ao menu iniciar
        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.main.Show();
            this.Close();
        }
        //botão em toolstrip para voltar ao gestao de funcionarios(grelha)
        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoFuncionariosButao = new GestaoFuncionariosTodos();
            gestaoFuncionariosButao.Show();
            this.Close();
        }
        //botão em toolstrip para voltar ao gestao de pareceres
        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPareceresButao = new GestaoParecer();
            gestaoPareceresButao.Show();
            this.Close();
        }
        //botão em toolstrip para voltar ao gestao de processos
        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestaoProcesso();
            gestaoProcessosButao.Show();
            this.Close();
        }
        //botão em toolstrip para voltar ao gestao de projetos
        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProjetosButao = new GestaoProjeto();
            gestaoProjetosButao.Show();
            this.Close();
        }
        //botão em toolstrip para voltar ao gestao de promotores
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestaoPromotore();
            gestaoPromotoresButao.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.gestãoFuncionario.Show();
            this.Close();
        }

        //Função para preencher a tabela com as entradas da adição de funcionários
        public void fillCells()
        {
            if (dBContainer.Funcionario.ToList<Funcionario>().Count != 0)
            {
                foreach (Funcionario func in dBContainer.Funcionario)
                {
                    dataGridView_funcionarios.Enabled = true;
                    dataGridView_funcionarios.Rows.Add(func.Nome, func.Extencao, func.Especialista.Count, func.ProjetoAtribuicao.Count, "Editar");
                }
            }
            else
            {
                dataGridView_funcionarios.Enabled = false;
            }
        }

        private void dataGridView_funcionarios_Click(object sender, EventArgs e)
        {
            if (dataGridView_funcionarios.SelectedRows != null && dataGridView_funcionarios.CurrentCell.ColumnIndex == 4)
            {
                Formularios.gestãoFuncionario.idfuncionario = dataGridView_funcionarios.CurrentCell.RowIndex;
                Formularios.gestãoFuncionario.populateTextBoxes();
                Formularios.gestãoFuncionario.Show();
                this.Close();
            }
        }
    }
}
