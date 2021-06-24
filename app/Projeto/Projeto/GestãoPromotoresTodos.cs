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
        //Inicializa o DBcontainer
        private DBContainer dBContainer;
        public GestãoPromotoresTodos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();

            addDados();

        }

        //Linhas 28 a 67 - Configuração de caminhos dos botões da toolstrip
        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoFuncionarios = new GestaoFuncionariosTodos();
            voltarGestaoFuncionarios.Show();
            this.Close();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoPareceres = new GestaoParecer();
            voltarGestaoPareceres.Show();
            this.Close();
        }

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoProcessos = new GestãoProcessosTodos();
            voltarGestaoProcessos.Show();
            this.Close();
        }

        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoProjetos = new GestãoProjetosTodos();
            voltarGestaoProjetos.Show();
            this.Close();
        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.main.Show();
            this.Close();
        }

        private void bt_adicionar_promotor_Click(object sender, EventArgs e)
        {
            Formularios.gestaoPromotore.Show();
            this.Close();
        }

        private void addDados()
        {

            foreach (Promotor promo in dBContainer.Promotor)
            {
                dataGridView_promotores.Rows.Add(promo.NIF, promo.Nome, promo.Morada, promo.Telemovel, promo.Email, promo.CodigoAcesso, (promo.Processo.Count + " (Adicionar)"));
            }
        }

        // Consoante seja uma celula normal ou um botão, esta função faz que, respetivamente, mostre o promotor no formulario de edição de promotores
        // ou todos os processos desse promotor no formulario de edicao de processos
        private void dataGridView_promotores_Click(object sender, EventArgs e)
        {
            if(dataGridView_promotores.CurrentCell.Value != null)
            {
                if (dataGridView_promotores.CurrentCell.ColumnIndex == 6)
                {
                    int promotor = dataGridView_promotores.CurrentCell.RowIndex;

                    Formularios.gestaoPromotore.idpromotor = promotor;

                    Formularios.gestaoProcesso.addProcessosListbox();

                    Formularios.gestaoProcesso.Show();

                    this.Close();

                }
                else {

                    int promotor = dataGridView_promotores.CurrentCell.RowIndex;

                    Formularios.gestaoPromotore.idpromotor = promotor;

                    Formularios.gestaoPromotore.populateTexBoxs();

                    Formularios.gestaoPromotore.Show();

                    this.Close();
                }
            }
        }


    }
}
