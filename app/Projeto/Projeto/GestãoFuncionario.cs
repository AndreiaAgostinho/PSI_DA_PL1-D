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
            foreach (TipoProjeto tipo in dBContainer.TipoProjeto) {
                checkbox_registro_funcionario.Items.Add(tipo);
                
                    }
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
            //Verificação da textbox: se o nome foi escrito
            //Caso não tenha sido escrito, o cursor posiciona-se na respetiva textbox
            if (string.IsNullOrEmpty(tb_nome_registro_funcionarios.Text))
            {
                MessageBox.Show("Insira um nome.", "Registro de Funcionários");
                tb_nome_registro_funcionarios.Select();
                return;
            }
            //Verificação da textbox: se a extensão foi escrita
            //Caso não tenha sido escrito, o cursor posiciona-se na respetiva textbox
            if (string.IsNullOrEmpty(tb_extensao_registro_funcionarios.Text))
            {
                MessageBox.Show("Insira uma extensão.", "Registro de Funcionários");
                tb_extensao_registro_funcionarios.Select();
                return;
            }
            //MessageBox que pergunta se deseja criar o utilizador.
            else
            {
                DialogResult result;
                result = MessageBox.Show("Quer salvar o registro?", "Registro de Funcionários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //se o resultado for sim o funcionario é criado apresentado uma mensagem dizendo que a acção foi executada com sucesso
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Funcionário salvo com sucesso!");
                    Funcionario func = new Funcionario();
                    func.Nome = tb_nome_registro_funcionarios.Text;
                    func.Extencao = tb_extensao_registro_funcionarios.Text;
                    if (checkbox_registro_funcionario.CheckedItems.Count >= 0)
                    {
                        foreach (TipoProjeto tipo in checkbox_registro_funcionario.CheckedItems)
                        {

                            Especialista especialista = new Especialista();
                            especialista.Funcionario = func;
                            especialista.TipoProjeto = tipo;
                            func.Especialista.Add(especialista);

                        }
                    }
                    dBContainer.Funcionario.Add(func);
                    dBContainer.SaveChanges();
                }
            }

            
        }
    }
}
