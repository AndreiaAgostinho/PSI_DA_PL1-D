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
        //Inicializa o DBcontainer
        private DBContainer dBContainer;
        public GestãoProjetosTodos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();

            populateCells();
        }

        //Linhas 26 a 65 - Configuração de caminhos dos botões da toolstrip
        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var processos = new GestãoProcessosTodos();
            processos.Show();
            this.Close();
        }

        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var funcionario = new GestaoFuncionariosTodos();
            funcionario.Show();
            this.Close();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parecer = new GestaoParecer();
            parecer.Show();
            this.Close();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var promotor = new GestãoPromotoresTodos();
            promotor.Show();
            this.Close();
        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.main.Show();
            this.Close();
        }

        private void bt_adicionar_projeto_Click(object sender, EventArgs e)
        {
            var projeto = new GestãoProjetosTodos();
            projeto.Show();
            this.Close();
        }


        //Apresentar a informação de um funcionário nas textbox e na checkbox
        private void populateCells()
        {
            if (dBContainer.ProjetoSet.ToList<Projeto>().Count != 0)
            {
                foreach (Promotor promo in dBContainer.Promotor.ToList<Promotor>())
                {
                    foreach (Processo processo in promo.Processo.ToList<Processo>())
                    {
                        foreach (Projeto projeto in processo.Projeto.ToList<Projeto>())
                        {
                            dataGridView_projetos.Rows.Add(projeto.TipoProjeto, processo.Id, promo, projeto.ProjetoAtribuicao.Last<ProjetoAtribuicao>().Funcionario, projeto.Documento.Count() + " (Adicionar)");
                            dataGridView_projetos.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                dataGridView_projetos.Enabled = false;
            }
        }

        //Ir buscar à bd os dados para preencher as tabelas
        private void dataGridView_projetos_Click(object sender, EventArgs e)
        {
            if (dataGridView_projetos.SelectedRows != null)
            {
                if (dataGridView_projetos.CurrentCell.ColumnIndex == 4)
                {
                    int idprojeto = dataGridView_projetos.CurrentCell.RowIndex;

                    Projeto projeto = dBContainer.ProjetoSet.ToList<Projeto>()[idprojeto];

                    Processo processo = projeto.Processo;

                    Promotor promo = processo.Promotor;

                    int i = 0;
                    foreach (Promotor promotor in dBContainer.Promotor.ToList<Promotor>())
                    {
                        if (promotor.Equals(promo))
                        {
                            Formularios.gestaoPromotore.idpromotor = i;
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    i = 0;
                    foreach (Processo process in promo.Processo)
                    {
                        if (process.Equals(processo))
                        {
                            Formularios.gestaoProcesso.idprocesso = i;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    i = 0;
                    foreach (Projeto proje in processo.Projeto)
                    {
                        if (proje.Equals(projeto))
                        {
                            Formularios.gestaoProjeto.idprojeto = i;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    Formularios.gestãoDocumentos.addDocumentoListBox();
                    Formularios.gestãoDocumentos.Show();

                    this.Close();

                }
                else
                {
                    int idprojeto = dataGridView_projetos.CurrentCell.RowIndex;

                    Projeto projeto = dBContainer.ProjetoSet.ToList<Projeto>()[idprojeto];

                    Processo processo = projeto.Processo;

                    Promotor promo = processo.Promotor;

                    int i = 0;
                    foreach (Promotor promotor in dBContainer.Promotor.ToList<Promotor>())
                    {
                        if (promotor.Equals(promo))
                        {
                            Formularios.gestaoPromotore.idpromotor = i;
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    i = 0;
                    foreach (Processo process in promo.Processo)
                    {
                        if (process.Equals(processo))
                        {
                            Formularios.gestaoProcesso.idprocesso = i;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    i = 0;
                    foreach (Projeto proje in processo.Projeto)
                    {
                        if (proje.Equals(projeto))
                        {
                            Formularios.gestaoProjeto.idprojeto = i;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    Formularios.gestaoProjeto.addProjetoListBox();

                    Formularios.gestaoProjeto.Show();

                    this.Close();
                }
            }
        }

        private void GestãoProjetosTodos_Load(object sender, EventArgs e)
        {

        }
    }
}
