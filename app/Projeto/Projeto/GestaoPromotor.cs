using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace Projeto
{

    public partial class GestaoPromotore : Form
    {
        private DBContainer dBContainer;
        public int idpromotor;
        public GestaoPromotore()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            listbox_promotor.DataSource = dBContainer.Promotor.ToList<Promotor>();


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
            
            
        }

        private void tb_morada_promotor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_nif_promotor_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void tb_telemovel_promotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

            private void tb_nif_promotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bt_guardar_promotor_Click(object sender, EventArgs e)
        {

            try
            {
                if (idpromotor == -1)
                {
                    Promotor promo = new Promotor();
                    promo.Nome = tb_nome_promotor.Text;
                    promo.Morada = tb_morada_promotor.Text;
                    promo.NIF = Int32.Parse(tb_nif_promotor.Text);
                    promo.Telemovel = tb_telemovel_promotor.Text;
                    promo.Email = tb_email_promotor.Text;
                    promo.CodigoAcesso = tb_codigo_acesso.Text;
                    promo.Senha = tb_senha_promotor.Text;
                    dBContainer.Promotor.Add(promo);
                    dBContainer.SaveChanges();
                    reloadDados();
                }
                else
                {
                    Promotor promo = dBContainer.Promotor.ToList<Promotor>()[idpromotor];
                    promo.Nome = tb_nome_promotor.Text;
                    promo.Morada = tb_morada_promotor.Text;
                    promo.NIF = Int32.Parse(tb_nif_promotor.Text);
                    promo.Telemovel = tb_telemovel_promotor.Text;
                    promo.Email = tb_email_promotor.Text;
                    promo.CodigoAcesso = tb_codigo_acesso.Text;
                    promo.Senha = tb_senha_promotor.Text;
                    dBContainer.SaveChanges();
                    reloadDados();
                }
                
                
            }
            catch (DbEntityValidationException a)
            {
                foreach (var eve in a.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gestaoProcessoButao = new GestaoProcesso();
            gestaoProcessoButao.Show();
            this.Hide();
        }

        private void reloadDados()
        {
            listbox_promotor.DataSource = null;
            listbox_promotor.DataSource = dBContainer.Promotor.ToList<Promotor>();
        }

        private void listbox_promotor_Click(object sender, EventArgs e)
        {
            if(listbox_promotor.SelectedItem != null)
            {
                
                Promotor promo = (Promotor)listbox_promotor.SelectedItem;

                idpromotor = listbox_promotor.SelectedIndex;

                tb_nome_promotor.Text = promo.Nome ;
                tb_morada_promotor.Text = promo.Morada;
                tb_nif_promotor.Text = Convert.ToString(promo.NIF);
                tb_telemovel_promotor.Text = promo.Telemovel;
                tb_email_promotor.Text = promo.Email;
                tb_codigo_acesso.Text = promo.CodigoAcesso ;
                tb_senha_promotor.Text = promo.Senha;

            }
        }

        public void populateTexBoxs()
        {
            Promotor promo = (Promotor)listbox_promotor.Items[idpromotor];

            tb_nome_promotor.Text = promo.Nome;
            tb_morada_promotor.Text = promo.Morada;
            tb_nif_promotor.Text = Convert.ToString(promo.NIF);
            tb_telemovel_promotor.Text = promo.Telemovel;
            tb_email_promotor.Text = promo.Email;
            tb_codigo_acesso.Text = promo.CodigoAcesso;
            tb_senha_promotor.Text = promo.Senha;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome_promotor.Text = "";
            tb_morada_promotor.Text = "";
            tb_nif_promotor.Text = "";
            tb_telemovel_promotor.Text = "";
            tb_email_promotor.Text = "";
            tb_codigo_acesso.Text = "";
            tb_senha_promotor.Text = "";

            idpromotor = -1;
        }
    }
}
