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
        //Inicializa o DBcontainer e inicializa os datasource das listbox e comboBoxs.
        public GestãoDocumentos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            comboBox_tipo_documento.DataSource = dBContainer.TipoDocumento.ToList<TipoDocumento>();
            lb_documento.DataSource = dBContainer.Documento.ToList<Documento>();
        }

        private void tb_nome_documento_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        //Armazena os documentos na sua tabela dentro da base de dados.
        private void bt_guardar_documento_Click(object sender, EventArgs e)
        {
            Documento doc = new Documento();
            doc.Titulo = tb_titulo_documento.Text;
            doc.DataEntrega = dateTimePicker_documento.Value;
            dBContainer.Documento.Add(doc);
            dBContainer.SaveChanges();


        }

        //botão em toolstrip para voltar ao gestao de promotores
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPromotoresButao = new GestaoPromotore();
            gestaoPromotoresButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de processos
        private void alteraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestaoProcesso();
            gestaoProcessosButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de projetos
        private void alteraçãoDeDadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var gestaoProjetoButao = new GestaoProjeto();
            gestaoProjetoButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar atras
        private void voltarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var gestaoProjetoButao = new GestaoProjeto();
            gestaoProjetoButao.Show();
            this.Hide();
        }

        //.
        private void GestãoDocumentos_Load(object sender, EventArgs e)
        {

        }
    }
}
