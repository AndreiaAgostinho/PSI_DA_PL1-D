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
        public int idprocesso = 0;
        public GestaoProcesso()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
        }

        //Linhas 24 a 70 - Configuração de caminhos dos botões da toolstrip
        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.main.Show();
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
            var gestaoProcessosButao = new GestãoProcessosTodos();
            gestaoProcessosButao.Show();
            this.Hide();
        }

        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProjetosButao = new GestãoProjetosTodos();
            gestaoProjetosButao.Show();
            this.Hide();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestãoPromotoresTodos();
            gestaoPromotoresButao.Show();
            this.Hide();
        }

        private void alteraçãoDeDadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formularios.gestaoPromotore.populateTexBoxs();
            Formularios.gestaoPromotore.Show();
            this.Hide();
        }

        //Adiciona os processos de um promotor à ListBox
        public void addProcessosListbox()
        {
            dBContainer.Dispose();
            dBContainer = new DBContainer();

            List<Promotor> promotores = dBContainer.Promotor.ToList<Promotor>();

            Promotor promo = promotores[Formularios.gestaoPromotore.idpromotor];

            listBox_processos.DataSource = null;
            listBox_processos.DataSource = promo.Processo.ToList<Processo>();

            comboBox_projetos.Items.Clear();
            label_aprovar.Visible = false;
            data_Processos.Enabled = true;
            data_Processos.Value = DateTime.Now;
        }

        //Guardar o processo - Adiciona um novo processo à base de dados
        private void bt_guardar_Click(object sender, EventArgs e)
        {

            if (idprocesso == -1)
            {
                Processo processo = new Processo();

                processo.DataInicio = data_Processos.Value.ToString();

                processo.EstadoProcesso = dBContainer.EstadoProcesso.ToList<EstadoProcesso>()[3];

                List<Promotor> promotores = dBContainer.Promotor.ToList<Promotor>();

                Promotor promo = promotores[Formularios.gestaoPromotore.idpromotor];

                promo.Processo.Add(processo);

                idprocesso = promo.Processo.Count - 1;


                dBContainer.SaveChanges();
                reloadDados();
            }
        }

        //Atualização de dados
        private void reloadDados()
        {
            List<Promotor> promotores = dBContainer.Promotor.ToList<Promotor>();

            Promotor promo = promotores[Formularios.gestaoPromotore.idpromotor];

            listBox_processos.DataSource = null;
            listBox_processos.DataSource = promo.Processo.ToList<Processo>();

            if (idprocesso != -1)
            {

                label_aprovar.Text = promo.Processo.Last<Processo>().EstadoProcesso.DescricaoEstado;
                label_aprovar.Visible = true;
                data_Processos.Enabled = false;
            }
            else
            {
                label_aprovar.Visible = false;
                data_Processos.Enabled = true;
            }


        }

        //Configuração da listbox para aparecerem os processos
        private void listBox_processos_Click(object sender, EventArgs e)
        {
            if (listBox_processos.SelectedItem != null)
            {
                idprocesso = listBox_processos.SelectedIndex;

                List<Promotor> promotores = dBContainer.Promotor.ToList<Promotor>();

                Promotor promo = promotores[Formularios.gestaoPromotore.idpromotor];

                Processo processo = promo.Processo.ToList<Processo>()[idprocesso];



                label_aprovar.Text = processo.EstadoProcesso.DescricaoEstado;
                label_aprovar.Visible = true;
                comboBox_projetos.Items.Clear();
                foreach (Projeto projeto in processo.Projeto.ToList<Projeto>())
                {
                    comboBox_projetos.Items.Add(projeto);
                }

                data_Processos.Value = Convert.ToDateTime(processo.DataInicio);
                data_Processos.Enabled = false;
            }
        }

        //Botão de Adicionar projeto
        private void bt_addprojeto_Click(object sender, EventArgs e)
        {
            if (idprocesso != -1)
            {
                Formularios.gestaoProjeto.addProjetoListBox();
                Formularios.gestaoProjeto.Show();
                this.Hide();
            }
        }

        //Apresentar a informação de um funcionário nas textbox e na checkbox
        public void populateTextBoxes()
        {
            if (listBox_processos.Items.Count != 0)
            {
                Processo processo = (Processo)listBox_processos.Items[idprocesso];

                listBox_processos.SelectedIndex = idprocesso;

                int var = 0;
                
                comboBox_projetos.Items.Clear();
                foreach (Projeto projeto in processo.Projeto.ToList<Projeto>())
                {
                    comboBox_projetos.Items.Add(projeto);
                    if (!projeto.EstadoProjeto.Equals("Aprovado"))
                    {
                        var = 1;
                    }
                }
                if(var == 0)
                {
                    processo.EstadoProcesso = dBContainer.EstadoProcesso.ToList<EstadoProcesso>()[1];
                }
                var = 0;
                label_aprovar.Text = processo.EstadoProcesso.DescricaoEstado;
                label_aprovar.Visible = true;

                data_Processos.Value = Convert.ToDateTime(processo.DataInicio);
                data_Processos.Enabled = false;
            }
            else
            {
                idprocesso = -1;
            }
        }

        //Botão de Limpar o que foi escrito/selecionado anteriormente
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            comboBox_projetos.Items.Clear();
            label_aprovar.Visible = false;
            data_Processos.Enabled = true;
            data_Processos.Value = DateTime.Now;
            idprocesso = -1;
        }

        public void addComboBox(Projeto projeto)
        {
            comboBox_projetos.Items.Add(projeto);
        }

        //Botão de remover processo
        private void button2_Click(object sender, EventArgs e)
        {
            if (idprocesso != -1)
            {
                DialogResult apagar;

                apagar = MessageBox.Show("Quer remover este Processo? Isto irá remover todos os projetos associados", "Remover Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (apagar == DialogResult.Yes)
                {
                    Processo processo = (Processo)listBox_processos.SelectedItem;

                    List<Projeto> projetos = processo.Projeto.ToList<Projeto>();

                    foreach (Projeto projeto in projetos)
                    {
                        List<ProjetoAtribuicao> projetoAtribuicaos = projeto.ProjetoAtribuicao.ToList<ProjetoAtribuicao>();
                        foreach (ProjetoAtribuicao projetoAtribuicao in projetoAtribuicaos)
                        {
                            dBContainer.ProjetoAtribuicao.Remove(projetoAtribuicao);
                        }

                        List<Parecer> pareceres = projeto.Parecer.ToList<Parecer>();
                        foreach (Parecer parecer in pareceres)
                        {
                            dBContainer.ParecerSet.Remove(parecer);
                        }

                        List<Documento> documentos = projeto.Documento.ToList<Documento>();
                        foreach (Documento doc in documentos)
                        {
                            dBContainer.Documento.Remove(doc);
                        }


                        dBContainer.ProjetoSet.Remove(projeto);

                    }

                    dBContainer.Processo.Remove(processo);

                    dBContainer.SaveChanges();

                    reloadDados();
                }
            }
        }

       
    }
}
