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
    public partial class GestãoDocumentos : Form
    {
        private DBContainer dBContainer;
        public int iddocumento = -1;
        //Inicializa o DBcontainer e inicializa os datasource das listbox e comboBoxs.
        public GestãoDocumentos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            comboBox_tipo_documento.DataSource = dBContainer.TipoDocumento.ToList<TipoDocumento>();
        }


        //Armazena os documentos na sua tabela dentro da base de dados.
        private void bt_guardar_documento_Click(object sender, EventArgs e)
        {
            if (iddocumento == -1)
            {

                Documento doc = new Documento();

                doc.Titulo = tb_titulo_documento.Text;

                doc.DataEntrega = dateTimePicker_documento.Value;


                if (comboBox_tipo_documento.SelectedItem != null)
                {
                    doc.TipoDocumento = (TipoDocumento)comboBox_tipo_documento.SelectedItem;
                }

                Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];

                Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];

                Projeto projeto = processo.Projeto.ToList<Projeto>()[Formularios.gestaoProjeto.idprojeto];

                doc.Parecer = projeto.Parecer.Last<Parecer>();
                projeto.Documento.Add(doc);

                projeto.EstadoProjeto = "À espera de aprovação";
                iddocumento = projeto.Documento.Count - 1;
                dBContainer.SaveChanges();
                reloadListbox();


            }
            else
            {
                Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];

                Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];

                Projeto projeto = processo.Projeto.ToList<Projeto>()[Formularios.gestaoProjeto.idprojeto];

                Documento doc = projeto.Documento.ToList<Documento>()[iddocumento];

                doc.Titulo = tb_titulo_documento.Text;

                if (comboBox_tipo_documento.SelectedItem != null)
                {
                    doc.TipoDocumento = (TipoDocumento)comboBox_tipo_documento.SelectedItem;
                }

                dBContainer.SaveChanges();
                reloadListbox();
            }
        }

        //Atualizar as listbox
        public void reloadListbox()
        {
            Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];

            Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];

            Projeto projeto = processo.Projeto.ToList<Projeto>()[Formularios.gestaoProjeto.idprojeto];

            lb_documento.DataSource = projeto.Documento.ToList<Documento>();

            if (iddocumento != -1)
            {
                dateTimePicker_documento.Enabled = false;
            }
            else
            {
                dateTimePicker_documento.Enabled = true;
            }
        }


        //botão em toolstrip para voltar ao gestao de promotores
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.gestaoPromotore.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de processos
        private void alteraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iddocumento = -1;
            Formularios.gestaoProcesso.addProcessosListbox();
            Formularios.gestaoProcesso.populateTextBoxes();
            Formularios.gestaoProcesso.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de projetos
        private void alteraçãoDeDadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            iddocumento = -1;
            Formularios.gestaoProjeto.addProjetoListBox();
            Formularios.gestaoProjeto.Show();
            this.Hide();
        }
       
        //Adição de documentos
        public void addDocumentoListBox()
        {
            Promotor promo = dBContainer.Promotor.ToList<Promotor>()[Formularios.gestaoPromotore.idpromotor];
            Console.WriteLine(Formularios.gestaoPromotore.idpromotor);
            Processo processo = promo.Processo.ToList<Processo>()[Formularios.gestaoProcesso.idprocesso];
            Console.WriteLine(Formularios.gestaoProcesso.idprocesso);
            Projeto projeto = processo.Projeto.ToList<Projeto>()[Formularios.gestaoProjeto.idprojeto];
            Console.WriteLine(Formularios.gestaoProjeto.idprojeto);
            lb_documento.DataSource = projeto.Documento.ToList<Documento>();
        }

       
        //Apresentação dos documentos na listbox
        private void lb_documento_Click(object sender, EventArgs e)
        {
            if (lb_documento.SelectedItem != null)
            {
                Documento doc = (Documento)lb_documento.SelectedItem;

                iddocumento = lb_documento.SelectedIndex;

                tb_titulo_documento.Text = doc.Titulo;

                comboBox_tipo_documento.SelectedItem = doc.TipoDocumento;
            }
        }

        //Limpar o titulo do documento e a data
        private void button_limpar_Click(object sender, EventArgs e)
        {
            tb_titulo_documento.Text = null;
            dateTimePicker_documento.Enabled = true;
            iddocumento = -1;
        }

        //Linhas 165 até 204 - Aceder a outros formulários
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

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.main.Show();
            this.Hide();
        }

        //Botão de Remover documento da listbox
        private void button_remover_Click(object sender, EventArgs e)
        {
            if (iddocumento != -1)
            {
                DialogResult apagar;

                apagar = MessageBox.Show("Quer remover o documento?", "Remover Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (apagar == DialogResult.Yes)
                {
                    Documento doc = (Documento)lb_documento.SelectedItem;

                    dBContainer.Documento.Remove(doc);

                    dBContainer.SaveChanges();

                    reloadListbox();
                }
            }
        }

    }
}
