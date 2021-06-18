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
    public partial class GestãoDocumentos : Form
    {
        private DBContainer dBContainer;
        public GestãoDocumentos()
        {
            InitializeComponent();
            dBContainer = new DBContainer();
            lb_documento.DataSource = dBContainer.Documento.ToList<Documento>();
            comboBox_funcionario_documento.DataSource = dBContainer.Funcionario.ToList<Funcionario>();
        }

        private void tb_nome_documento_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void bt_guardar_documento_Click(object sender, EventArgs e)
        {
            Documento doc = new Documento();
            doc.Titulo = tb_titulo_documento.Text;
        }
    }
}
