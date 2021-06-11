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
    public partial class GestaoPromotore : Form
    {
        public GestaoPromotore()
        {
            InitializeComponent();
        }

        private void GestaoPromotores_Load(object sender, EventArgs e)
        {

        }

        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var voltarGestaoPromotores = new MainPage();
            voltarGestaoPromotores.Show();
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

        private void alteraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_nome_promotor_TextChanged(object sender, EventArgs e)
        {
            Promotor promo = new Promotor();
            promo.Nome = tb_nome_promotor.Text;
            
        }

        private void tb_morada_promotor_TextChanged(object sender, EventArgs e)
        {
            Promotor promo = new Promotor();
            promo.Morada = tb_morada_promotor.Text;
        }

        private void tb_nif_promotor_TextChanged(object sender, EventArgs e)
        {
            Promotor promo = new Promotor();
            promo.NIF = Int32.Parse(tb_nif_promotor.Text);
        }

        private void tb_nif_promotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
