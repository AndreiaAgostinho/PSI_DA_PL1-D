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
        //Inicializa o DBcontainer
        private DBContainer dBContainer;
        public GestãoProcessosTodos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();

            populateCells();
        }

        //Linhas 26 a 60 - Configuração de caminhos dos botões da toolstrip
        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var funcionarios = new GestaoFuncionariosTodos();
            funcionarios.Show();
            this.Close();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pareceres = new GestaoParecer();
            pareceres.Show();
            this.Close();
        }


        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Projetos = new GestãoProjetosTodos();
            Projetos.Show();
            this.Close();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var promotores = new GestãoPromotoresTodos();
            promotores.Show();
            this.Close();
        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new MainPage();
            menu.Show();
            this.Close();
        }

        //Apresentar a informação de um funcionário nas textbox e na checkbox
        private void populateCells()
        {
            if (dBContainer.Processo.ToList<Processo>().Count != 0)
            {
                foreach (Promotor promo in dBContainer.Promotor.ToList<Promotor>())
                {
                    foreach (Processo processo in promo.Processo.ToList<Processo>())
                    {
                        dataGridView_processos.Rows.Add(processo.DataInicio, processo.Id, processo.Promotor, processo.Projeto.Count() + " (Adicionar)");
                        dataGridView_processos.Enabled = true;
                    }
                }
            }
            else
            {
                dataGridView_processos.Enabled = false;
            }
        }

        //Função para preencher a tabela com as entradas da adição de Processos
        private void dataGridView_processos_Click(object sender, EventArgs e)
        {
            if (dataGridView_processos.SelectedRows != null)
            {
                if (dataGridView_processos.CurrentCell.ColumnIndex == 3)
                {
                    int idprocesso = dataGridView_processos.CurrentCell.RowIndex;

                    Processo processo = dBContainer.Processo.ToList<Processo>()[idprocesso];

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


                    Formularios.gestaoProjeto.addProjetoListBox();

                    Formularios.gestaoProjeto.Show();

                    this.Close();

                }
                else
                {
                    int idprocesso = dataGridView_processos.CurrentCell.RowIndex;

                    Processo processo = dBContainer.Processo.ToList<Processo>()[idprocesso];

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
                    Formularios.gestaoProcesso.addProcessosListbox();

                    Formularios.gestaoProcesso.populateTextBoxes();

                    Formularios.gestaoProcesso.Show();

                    this.Close();
                }
            }
        }

    }
}
