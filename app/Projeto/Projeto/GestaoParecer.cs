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
        //Criação de tabela na base de dados
        private DBContainer dBContainer;
        public GestaoParecer()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            combo_funcionario.DataSource = dBContainer.Funcionario.ToList<Funcionario>();

        }

        //Linhas 26 a 65 - Configuração de caminhos dos botões da toolstrip
        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.main.Show();
            this.Close();
        }

        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoFuncionariosButao = new GestaoFuncionariosTodos();
            gestaoFuncionariosButao.Show();
            this.Close();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPareceresButao = new GestaoParecer();
            gestaoPareceresButao.Show();
            this.Close();
        }

        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProjetosButao = new GestãoProjetosTodos();
            gestaoProjetosButao.Show();
            this.Close();
        }

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestãoProcessosTodos();
            gestaoProcessosButao.Show();
            this.Close();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestãoPromotoresTodos();
            gestaoPromotoresButao.Show();
            this.Close();
        }

        //Configuração do botão de aprovar - Reporta no estado do projeto como 'Aprovado'
        private void combo_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcionario func = dBContainer.Funcionario.ToList<Funcionario>()[combo_funcionario.SelectedIndex];
            combobox_projeto_associado.Items.Clear();
            combobox_projeto_associado.Text = null;
            foreach (ProjetoAtribuicao projeto in func.ProjetoAtribuicao.ToArray<ProjetoAtribuicao>())
            {
                if (!projeto.Projeto.EstadoProjeto.Equals("Aprovado"))
                {
                    combobox_projeto_associado.Items.Add(projeto);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario func = dBContainer.Funcionario.ToList<Funcionario>()[combo_funcionario.SelectedIndex];
            Projeto projeto = func.ProjetoAtribuicao.ToList<ProjetoAtribuicao>()[combobox_projeto_associado.SelectedIndex].Projeto;
            Parecer parecer = new Parecer();
            parecer.DataParecer = datapicker_parecer.Value.ToString();
            parecer.TextoParecer = tb_observacoes.Text;
            parecer.Funcionario = func;
            projeto.DataAprovação = datapicker_parecer.Value;
            projeto.EstadoProjeto = "Aprovado";
            projeto.Parecer.Add(parecer);
            dBContainer.SaveChanges();
        }

        //Configuração do botão de não aprovar - Reporta no estado do projeto como 'Não Aprovado'
        private void bt_nao_aprovar_Click(object sender, EventArgs e)
        {
            Funcionario func = dBContainer.Funcionario.ToList<Funcionario>()[combo_funcionario.SelectedIndex];
            Projeto projeto = func.ProjetoAtribuicao.ToList<ProjetoAtribuicao>()[combobox_projeto_associado.SelectedIndex].Projeto;
            Parecer parecer = new Parecer();
            parecer.DataParecer = datapicker_parecer.Value.ToString();
            parecer.TextoParecer = tb_observacoes.Text;
            parecer.Funcionario = func;
            projeto.EstadoProjeto = "Não Aprovado";
            projeto.Parecer.Add(parecer);
            dBContainer.SaveChanges();
        }
    }
}
