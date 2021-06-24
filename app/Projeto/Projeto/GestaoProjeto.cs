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
            //if para determinar se o projeto esta por aprovar, se faltam documentos, se foi aprovado ou nao
            if(comboBox_documento_projeto.Items.Count != 0)
            {
                foreach(Documento documentos in comboBox_documento_projeto.Items)
                {
                    projeto.Documento.Add(documentos);
                    projeto.EstadoProjeto = "Por Aprovar";
                    label5.ForeColor = Color.Yellow;
                }
            }
            else
            {
                projeto.EstadoProjeto = "Falta Documentos";
                label5.ForeColor = Color.OrangeRed;
            }

            if (comboBox_tipo_projeto.SelectedItem != null) {
                projeto.TipoProjeto = (TipoProjeto)comboBox_tipo_projeto.SelectedItem;
            }

            //atribuição de um funcionarios a um projeto(especialidade)
            if(comboBox_funcionario_projeto.SelectedItem != null)
            {
                ProjetoAtribuicao atribuicao = new ProjetoAtribuicao();

                atribuicao.Funcionario = (Funcionario)comboBox_funcionario_projeto.SelectedItem;
                atribuicao.Data = dateTimePicker_projetos.Value.ToString();
                atribuicao.Projeto = projeto;
                projeto.ProjetoAtribuicao.Add(atribuicao);
            }

            Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];

            Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];

            processo.Projeto.Add(projeto);

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
            Formularios.gestaoPromotore.Show();
            this.Hide();
        }

        private void alteraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.gestaoProcesso.Show();
            this.Hide();
        }

        public void addProjetoListBox()
        {
            Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];

            Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];

            lb_projetos.DataSource = processo.Projeto.ToList<Projeto>();
        }

        private void comboBox_tipo_projeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoProjeto tipo = (TipoProjeto)comboBox_tipo_projeto.SelectedItem;

            List<Funcionario> lista = new List<Funcionario>();

            foreach(Funcionario func in dBContainer.Funcionario)
            {
                foreach(Especialista espe in func.Especialista)
                {
                    if(espe.TipoProjeto == tipo)
                    {
                        lista.Add(func);
                    }
                }
            }
            comboBox_funcionario_projeto.DataSource = lista;
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
