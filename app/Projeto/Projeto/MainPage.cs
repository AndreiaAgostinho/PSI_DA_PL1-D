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
    public partial class MainPage : Form
    {
        //Inicializar os formulários
        public MainPage()
        {
            InitializeComponent();
            Formularios.gestaoPromotore = new GestaoPromotore();
            Formularios.gestaoProcesso = new GestaoProcesso();
            Formularios.gestaoProjeto = new GestaoProjeto();
            Formularios.gestãoDocumentos = new GestãoDocumentos();
            Formularios.gestãoFuncionario = new GestãoFuncionario();
        }

    


        //Animação p/ main page - passar com o rato por cima para aparecerem os botões
     

        private void button1_Click(object sender, EventArgs e)
        {
            var gestaofuncionariosinicial = new GestaoFuncionariosTodos();
            gestaofuncionariosinicial.Show();
            this.Hide();
        }

        private void btGestaoProcessos_Click(object sender, EventArgs e)
        {
            var gestaoprocessos = new GestãoProcessosTodos();
            gestaoprocessos.Show();
            this.Hide();
        }

        private void btGestaoPrometor_Click(object sender, EventArgs e)
        {
            var gestaopromotores = new GestãoPromotoresTodos();
            gestaopromotores.Show();
            this.Hide();
        }

        private void btGestaoPareceres_Click(object sender, EventArgs e)
        {
            var gestaopareceres = new GestaoParecer();
            gestaopareceres.Show();
            this.Hide();
        }

        private void btGestaoProjetos_Click(object sender, EventArgs e)
        {
            var gestaoprojetos = new GestãoProjetosTodos();
            gestaoprojetos.Show();
            this.Hide(); 
        }

    }
}
