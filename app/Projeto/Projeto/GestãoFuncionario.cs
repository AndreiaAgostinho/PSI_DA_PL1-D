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
        public int idfuncionario = -1;
        //Inicializa a checkbox com ligação as especialidades.
        public GestãoFuncionario()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            foreach (TipoProjeto tipo in dBContainer.TipoProjeto)
            {
                checkbox_registro_funcionario.Items.Add(tipo);
            }
        }

        //botão em toolstrip para voltar ao menu iniciar
        private void menuIniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.main.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de funcionarios
        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoFuncionariosButao = new GestaoFuncionariosTodos();
            gestaoFuncionariosButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de pareceres
        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoPareceresButao = new GestaoParecer();
            gestaoPareceresButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de processos
        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProcessosButao = new GestaoProcesso();
            gestaoProcessosButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de projetos
        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestaoProjetosButao = new GestaoProjeto();
            gestaoProjetosButao.Show();
            this.Hide();
        }
        //botão em toolstrip para voltar ao gestao de promotores
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
                    //guarda os dados dos funcionarios e as especialidades na sua respetiva tabela na base de dados
                    if (idfuncionario == -1)
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
                    else
                    {
                        int var = 0;
                        Funcionario func = dBContainer.Funcionario.ToList<Funcionario>()[idfuncionario];
                        func.Nome = tb_nome_registro_funcionarios.Text;
                        func.Extencao = tb_extensao_registro_funcionarios.Text;
                        if (checkbox_registro_funcionario.CheckedItems.Count >= 0)
                        {
                            foreach (TipoProjeto tipo in checkbox_registro_funcionario.CheckedItems)
                            {

                                Especialista especialista = new Especialista();
                                especialista.Funcionario = func;
                                especialista.TipoProjeto = tipo;

                                foreach (Especialista espe in func.Especialista)
                                {
                                    if (espe.TipoProjetoId == tipo.Id)
                                    {
                                        var = 1;
                                        break;
                                    }
                                }

                                if (var == 0)
                                {
                                    Console.WriteLine("hello");
                                    func.Especialista.Add(especialista);
                                }
                                var = 0;

                            }
                        }
                        dBContainer.SaveChanges();
                    }
                }

            }
        }

        //Apresentar a informação de um funcionário nas textbox e na checkbox
        public void populateTextBoxes()
        {
            Funcionario func = dBContainer.Funcionario.ToList<Funcionario>()[idfuncionario];

            tb_nome_registro_funcionarios.Text = func.Nome;

            tb_extensao_registro_funcionarios.Text = func.Extencao;

            foreach (Especialista especialista in func.Especialista)
            {
                foreach (TipoProjeto tipo in dBContainer.TipoProjeto)
                {
                    if (tipo.Equals(especialista.TipoProjeto))
                    {
                        checkbox_registro_funcionario.SetItemChecked(checkbox_registro_funcionario.Items.IndexOf(tipo), true);
                    }
                }
            }
        }

       
    }
}
