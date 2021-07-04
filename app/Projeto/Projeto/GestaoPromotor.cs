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

    //Inicializa o DBcontainer
    public partial class GestaoPromotore : Form
    {
        private DBContainer dBContainer;
        public int idpromotor = -1;
        public GestaoPromotore()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            listbox_promotor.DataSource = dBContainer.Promotor.ToList<Promotor>();

        }

        //Linhas 31 a 70 - Configuração de caminhos dos botões da toolstrip

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

        //codigo para textbox de telemovel so aceitar numeros
        private void tb_telemovel_promotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        //codigo para textbox de nif aceitar numeros
        private void tb_nif_promotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        //guarda os promotores novos e os seus devidos dados na base de dados
        private void bt_guardar_promotor_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrWhiteSpace(tb_nome_promotor.Text))
                    throw new EmptyTextbox();
                if (String.IsNullOrWhiteSpace(tb_morada_promotor.Text))
                    throw new EmptyTextbox();
                if (String.IsNullOrWhiteSpace(tb_telemovel_promotor.Text))
                    throw new EmptyTextbox();
                if (String.IsNullOrWhiteSpace(tb_email_promotor.Text))
                    throw new EmptyTextbox();
                if (String.IsNullOrWhiteSpace(tb_codigo_acesso.Text))
                    throw new EmptyTextbox();
                if (String.IsNullOrWhiteSpace(tb_senha_promotor.Text))
                    throw new EmptyTextbox();


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

                    foreach(Promotor promotor in dBContainer.Promotor)
                    {
                        if(promo.NIF == promotor.NIF)
                        {
                            throw new IDExistente();
                        }
                    }
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
            catch (FormatException)
            {
                MessageBox.Show("NIF Inválido");
            }
            catch (IDExistente)
            {
                MessageBox.Show("Promotor com NIF já existente");
            }
            catch (EmptyTextbox)
            {
                MessageBox.Show("Preencha todas as caixas de texto");
            }

        }

        //refresh nos dados do formulario
        private void reloadDados()
        {
            listbox_promotor.DataSource = null;
            listbox_promotor.DataSource = dBContainer.Promotor.ToList<Promotor>();
        }
        //preenche as textboxs com o promotor selecionado da listbox
        private void listbox_promotor_Click(object sender, EventArgs e)
        {
            if (listbox_promotor.SelectedItem != null)
            {

                Promotor promo = (Promotor)listbox_promotor.SelectedItem;

                idpromotor = listbox_promotor.SelectedIndex;

                tb_nome_promotor.Text = promo.Nome;
                tb_morada_promotor.Text = promo.Morada;
                tb_nif_promotor.Text = Convert.ToString(promo.NIF);
                tb_telemovel_promotor.Text = promo.Telemovel;
                tb_email_promotor.Text = promo.Email;
                tb_codigo_acesso.Text = promo.CodigoAcesso;
                tb_senha_promotor.Text = promo.Senha;

            }
        }

        public void populateTexBoxs()
        {

            Promotor promo = (Promotor)listbox_promotor.Items[idpromotor];

            listbox_promotor.SelectedIndex = idpromotor;

            tb_nome_promotor.Text = promo.Nome;
            tb_morada_promotor.Text = promo.Morada;
            tb_nif_promotor.Text = Convert.ToString(promo.NIF);
            tb_telemovel_promotor.Text = promo.Telemovel;
            tb_email_promotor.Text = promo.Email;
            tb_codigo_acesso.Text = promo.CodigoAcesso;
            tb_senha_promotor.Text = promo.Senha;
        }
        //butao para limpar os dados da textboxs
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
        //mantem os formularios em execução para nao se perderem dados
        private void bt_processo_Click(object sender, EventArgs e)
        {
            if (idpromotor != -1)
            {
                Formularios.gestaoProcesso.addProcessosListbox();
                Formularios.gestaoProcesso.populateTextBoxes();
                Formularios.gestaoProcesso.Show();
                this.Hide();
            }
        }

        private void bt_remover_promotor_Click(object sender, EventArgs e)
        {
            if(idpromotor != -1)
            {
                DialogResult apagar;

                apagar = MessageBox.Show("Quer remover este Promotor? Isto irá remover todos os processos associados", "Remover Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (apagar == DialogResult.Yes)
                {
                    Promotor promotor = (Promotor)listbox_promotor.SelectedItem;

                    List<Processo> processos = promotor.Processo.ToList<Processo>();
                    foreach (Processo processo in processos)
                    {
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
                    }

                    dBContainer.Promotor.Remove(promotor);

                    dBContainer.SaveChanges();

                    reloadDados();
                }
            }
        }
    }
}
