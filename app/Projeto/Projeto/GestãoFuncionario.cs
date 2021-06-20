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
    public partial class GestãoFuncionario : Form
    {
        private DBContainer dBContainer;
        public GestãoFuncionario()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            //checkbox_registro_funcionario.data
        }


        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarMenuInicialRegistroFuncionarios = new MainPage();
            voltarMenuInicialRegistroFuncionarios.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Nome = tb_nome_registro_funcionarios.Text;
            func.Extencao = tb_extensao_registro_funcionarios.Text;
            if(checkbox_registro_funcionario.CheckedItems.Count >= 0)
            {
                //checkbox_registro_funcionario.Text;
            }
            dBContainer.Funcionario.Add(func);
            dBContainer.SaveChanges();

            
        }
    }
}
