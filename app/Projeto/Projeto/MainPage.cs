﻿using System;
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
        public MainPage()
        {
            InitializeComponent();
        }

        private void gestoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //Animação p/ main page - passar com o rato por cima para aparecerem os botões
        private void True(object sender, DragEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gestaofuncionariosinicial = new GestaoFuncionariosInicial();
            gestaofuncionariosinicial.Show();
            this.Hide();
        }

        private void btGestaoProcessos_Click(object sender, EventArgs e)
        {
            var gestaoprocessos = new GestaoProcessosInicial();
            gestaoprocessos.Show();
            this.Hide();
        }

        private void btGestaoPrometor_Click(object sender, EventArgs e)
        {
            var gestaopromotores = new GestaoPromotoresInicial();
            gestaopromotores.Show();
            this.Hide();
        }

        private void btGestaoPareceres_Click(object sender, EventArgs e)
        {
            var gestaopareceres = new GestaoPareceres();
            gestaopareceres.Show();
            this.Hide();
        }

        private void btGestaoProjetos_Click(object sender, EventArgs e)
        {
            var gestaoprojetos = new GestaoProjetosInicial();
            gestaoprojetos.Show();
            this.Hide();
        }
    }
}