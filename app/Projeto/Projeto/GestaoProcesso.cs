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
    public partial class GestaoProcesso : Form
    {
        private DBContainer dBContainer;
        public int idprocesso  = 0;
        public GestaoProcesso()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoProcessos = new MainPage();
            voltarGestaoProcessos.Show();
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

        private void alteraçãoDeDadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formularios.gestaoPromotore.Show();
            this.Hide();
        }

        //Adiciona os processos de um promotor à ListBox
        public void addProcessosListbox()
        {
            List<Promotor> promotores = dBContainer.Promotor.ToList<Promotor>();

            Promotor promo = promotores[Formularios.gestaoPromotore.idpromotor];

            listBox_processos.DataSource = promo.Processo.ToList<Processo>();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {

            if (idprocesso != -1)
            {
                Processo processo = new Processo();

                processo.DataInicio = data_Processos.Value.ToString();

                EstadoProcesso estado = new EstadoProcesso();

                if (comboBox_projetos.Items.Count != 0)
                {
                    foreach (Projeto projeto in comboBox_projetos.Items)
                    {
                        processo.Projeto.Add(projeto);
                    }
                    estado = dBContainer.EstadoProcesso.ToList<EstadoProcesso>()[0];
                }
                else
                {
                    estado = dBContainer.EstadoProcesso.ToList<EstadoProcesso>()[3];
                }

                estado.Processo.Add(processo);

                List<Promotor> promotores = dBContainer.Promotor.ToList<Promotor>();

                Promotor promo = promotores[Formularios.gestaoPromotore.idpromotor];

                promo.Processo.Add(processo);

                idprocesso = promo.Processo.Count - 1;

                dBContainer.SaveChanges();
                reloadDados();
            }
            else
            {
                Processo processo = (Processo)listBox_processos.SelectedItem;

                if (comboBox_projetos.Items.Count != 0)
                {
                    foreach (Projeto projeto in comboBox_projetos.Items)
                    {
                        if (!processo.Projeto.Contains(projeto))
                        {
                            processo.Projeto.Add(projeto);
                        }
                        
                    }
                    processo.EstadoProcesso = dBContainer.EstadoProcesso.ToList<EstadoProcesso>()[0];
                }
            }
        }

        private void reloadDados()
        {
            List<Promotor> promotores = dBContainer.Promotor.ToList<Promotor>();

            Promotor promo = promotores[Formularios.gestaoPromotore.idpromotor];

            listBox_processos.DataSource = null;
            listBox_processos.DataSource = promo.Processo.ToList<Processo>();

            int count = listBox_processos.Items.Count;

            label_aprovar.Text = promo.Processo.Last<Processo>().EstadoProcesso.DescricaoEstado;
            label_aprovar.Visible = true;


        }

        private void listBox_processos_Click(object sender, EventArgs e)
        {
            if (listBox_processos.SelectedItem != null)
            {
                Processo processo = (Processo)listBox_processos.SelectedItem;

                idprocesso = listBox_processos.SelectedIndex;

                label_aprovar.Text = processo.EstadoProcesso.DescricaoEstado;
                label_aprovar.Visible = true;
                comboBox_projetos.Items.AddRange(processo.Projeto.ToArray<Projeto>());

                data_Processos.Value = Convert.ToDateTime(processo.DataInicio);
                data_Processos.Enabled = false;
            }
        }

        private void bt_addprojeto_Click(object sender, EventArgs e)
        {
            Formularios.gestaoProjeto.Show();
            this.Hide();
        }

        public void populateTextBoxes()
        {
            Processo processo = (Processo)listBox_processos.Items[idprocesso];

            label_aprovar.Text = processo.EstadoProcesso.DescricaoEstado;
            label_aprovar.Visible = true;
            comboBox_projetos.Items.AddRange(processo.Projeto.ToArray<Projeto>());

            data_Processos.Value = Convert.ToDateTime(processo.DataInicio);
            data_Processos.Enabled = false;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            comboBox_projetos.Items.Clear();
            label_aprovar.Visible = false;
            idprocesso = -1;
        }
    }
}
