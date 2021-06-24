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
        //Inicializa o DBcontainer
        private DBContainer dBContainer;
        public int idprojeto = -1;
        public GestaoProjeto()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            comboBox_tipo_projeto.DataSource = dBContainer.TipoProjeto.ToList<TipoProjeto>();

        }

        //Linhas 27 a 66 - Configuração de caminhos dos botões da toolstrip
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

        //Botão para guardar o projeto na bd, atualizar os projetos
        private void bt_guardar_projeto_Click(object sender, EventArgs e)
        {
            //Se faltar documentos, aparece verificação 'Falta Documentos' e não guarda
            if (idprojeto == -1)
            {
                Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];

                Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];

                Projeto projeto = new Projeto();
                projeto.DataEntrega = dateTimePicker_projetos.Value.Date;
                projeto.DataAprovação = dateTimePicker_projetos.MinDate;
                projeto.EstadoProjeto = "Falta Documentos";
                label_aprovar.Visible = true; ;

                if (comboBox_tipo_projeto.SelectedItem != null)
                {

                    projeto.TipoProjeto = dBContainer.TipoProjeto.ToList<TipoProjeto>()[comboBox_tipo_projeto.SelectedIndex];
                }
                else
                {
                    return;
                }

                //Se os documentos estiverem corretos, adiciona-os na base de dados
                if (comboBox_funcionario_projeto.SelectedItem != null)
                {
                    ProjetoAtribuicao atribuicao = new ProjetoAtribuicao();

                    atribuicao.Funcionario = (Funcionario)comboBox_funcionario_projeto.SelectedItem;
                    atribuicao.Data = dateTimePicker_projetos.Value.ToString();
                    atribuicao.Projeto = projeto;
                    projeto.ProjetoAtribuicao.Add(atribuicao);

                    Parecer parecer = new Parecer();
                    parecer.DataParecer = dateTimePicker_projetos.MinDate.ToString();
                    parecer.TextoParecer = "";
                    parecer.Funcionario = (Funcionario)comboBox_funcionario_projeto.SelectedItem;

                    projeto.Parecer.Add(parecer);
                }
                else
                {
                    return;
                }

                processo.Projeto.Add(projeto);
                processo.EstadoProcesso = dBContainer.EstadoProcesso.ToList<EstadoProcesso>()[0];
                idprojeto = processo.Projeto.Count - 1;

                projeto = processo.Projeto.Last<Projeto>();

                if (comboBox_funcionario_projeto.SelectedItem != null)
                {
                    ProjetoAtribuicao atribuicao = new ProjetoAtribuicao();

                    atribuicao.Funcionario = (Funcionario)comboBox_funcionario_projeto.SelectedItem;
                    atribuicao.Data = dateTimePicker_projetos.Value.ToString();
                    atribuicao.Projeto = projeto;
                    projeto.ProjetoAtribuicao.Add(atribuicao);

                    Parecer parecer = new Parecer();
                    parecer.DataParecer = dateTimePicker_projetos.MinDate.ToString();
                    parecer.TextoParecer = "";
                    parecer.Funcionario = (Funcionario)comboBox_funcionario_projeto.SelectedItem;

                    projeto.Parecer.Add(parecer);
                }
                else
                {
                    return;
                }
                dateTimePicker_projetos.Enabled = false;

                dBContainer.SaveChanges();
                idprojeto = processo.Projeto.Count - 1;
                reloadDados();
            }
            else
            {

                Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];

                Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];

                Projeto projeto = processo.Projeto.ToList<Projeto>()[idprojeto];

                if (comboBox_tipo_projeto.SelectedItem != null)
                {
                    projeto.TipoProjeto = dBContainer.TipoProjeto.ToList<TipoProjeto>()[comboBox_tipo_projeto.SelectedIndex];
                }

                if (comboBox_funcionario_projeto.SelectedItem != null)
                {
                    ProjetoAtribuicao atribuicao = new ProjetoAtribuicao();

                    atribuicao.Funcionario = (Funcionario)comboBox_funcionario_projeto.SelectedItem;
                    atribuicao.Data = dateTimePicker_projetos.Value.ToString();
                    atribuicao.Projeto = projeto;
                    projeto.ProjetoAtribuicao.Add(atribuicao);
                }

                dBContainer.SaveChanges();
                reloadDados();
            }

        }

        //Atualização dos dados (documentos) no bdcontainer
        private void reloadDados()
        {
            dBContainer.Dispose();
            dBContainer = new DBContainer();
            List<Promotor> promotores = dBContainer.Promotor.ToList<Promotor>();

            Promotor promo = promotores[Formularios.gestaoPromotore.idpromotor];

            Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];


            lb_projetos.DataSource = null;
            lb_projetos.DataSource = processo.Projeto.ToList<Projeto>();

            if (idprojeto != -1)
            {
                label_aprovar.Text = processo.Projeto.Last<Projeto>().EstadoProjeto;
                label_aprovar.Visible = true;
            }
            else
            {
                label_aprovar.Visible = false;
            }


        }

        //Adiciona o projeto à list box e verificar o estado do projeto, apresentando-no na label
        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.gestãoDocumentos.addDocumentoListBox();
            Formularios.gestãoDocumentos.Show();
            this.Hide();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idprojeto = -1;
            Formularios.gestaoPromotore.Show();
            this.Hide();
        }

        private void alteraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idprojeto = -1;
            Formularios.gestaoProcesso.addProcessosListbox();
            Formularios.gestaoProcesso.populateTextBoxes();
            Formularios.gestaoProcesso.Show();
            this.Hide();
        }

        //Linhas 220 a 273 - Apresentar nas combobox os projetos, os tipos de projetos
        //E os funcionários associados ao projeto
        public void addProjetoListBox()
        {
            dBContainer.Dispose();
            dBContainer = new DBContainer();

            Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];

            Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];

            lb_projetos.DataSource = processo.Projeto.ToList<Projeto>();

            if (idprojeto != -1)
            {
                lb_projetos.SelectedIndex = idprojeto;

                Projeto projeto = (Projeto)lb_projetos.SelectedItem;

                comboBox_documento_projeto.Items.Clear();
                comboBox_documento_projeto.Items.AddRange(projeto.Documento.ToArray<Documento>());

                label_aprovar.Text = projeto.EstadoProjeto;

            }


        }


        private void lb_projetos_Click(object sender, EventArgs e)
        {
            if (lb_projetos.SelectedItem != null)
            {
                Projeto projeto = (Projeto)lb_projetos.SelectedItem;

                idprojeto = lb_projetos.SelectedIndex;

                label_aprovar.Visible = true;
                dateTimePicker_projetos.Enabled = false;

                comboBox_documento_projeto.Items.Clear();
                comboBox_documento_projeto.Items.AddRange(projeto.Documento.ToArray<Documento>());

                foreach (TipoProjeto tipo in comboBox_tipo_projeto.Items)
                {
                    if (tipo.Id == projeto.TipoProjeto.Id)
                    {
                        comboBox_tipo_projeto.SelectedIndex = comboBox_tipo_projeto.Items.IndexOf(tipo);
                        break;
                    }
                }

                List<Funcionario> lista = new List<Funcionario>();

                foreach (Funcionario func in dBContainer.Funcionario)
                {
                    foreach (Especialista espe in func.Especialista)
                    {
                        if (espe.TipoProjeto.Id == projeto.TipoProjeto.Id)
                        {

                            lista.Add(func);
                        }
                    }
                }

                comboBox_funcionario_projeto.DataSource = null;
                comboBox_funcionario_projeto.DataSource = lista;


                foreach (Funcionario func in comboBox_funcionario_projeto.Items)
                {
                    if (func.Numero == projeto.ProjetoAtribuicao.Last<ProjetoAtribuicao>().Funcionario.Numero)
                    {
                        comboBox_funcionario_projeto.SelectedIndex = comboBox_funcionario_projeto.Items.IndexOf(func);
                        break;
                    }
                }

                label_aprovar.Text = projeto.EstadoProjeto;
            }
        }

        //Botão de Limpar o que foi escrito/selecionado anteriormente
        private void button_limpar_Click(object sender, EventArgs e)
        {
            dBContainer.Dispose();
            dBContainer = new DBContainer();
            idprojeto = -1;
            comboBox_funcionario_projeto.DataSource = null;
            dateTimePicker_projetos.Enabled = true;
            label_aprovar.Visible = false;
        }

        //Para cada tipo de projeto, ir buscar e apresentar
        //o respetivo especialista indicado à função
        private void comboBox_tipo_projeto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TipoProjeto tipo = (TipoProjeto)comboBox_tipo_projeto.SelectedItem;

            List<Funcionario> lista = new List<Funcionario>();

            foreach (Funcionario func in dBContainer.Funcionario)
            {
                foreach (Especialista espe in func.Especialista)
                {
                    if (espe.TipoProjeto.Id == tipo.Id)
                    {
                        lista.Add(func);
                    }
                }
            }
                comboBox_funcionario_projeto.DataSource = null;
                comboBox_funcionario_projeto.DataSource = lista;

            
            
        }


        private void buttom_remover_Click(object sender, EventArgs e)
        {
            if (idprojeto != -1)
            {
                DialogResult apagar;

                apagar = MessageBox.Show("Quer remover este Projeto? Isto irá remover todos os documentos associados", "Remover Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (apagar == DialogResult.Yes)
                {
                    Projeto projeto = (Projeto)lb_projetos.SelectedItem;

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

                    dBContainer.SaveChanges();

                    reloadDados();
                }
            }
        }

    }
}
