
namespace Projeto
{
    partial class GestaoProcesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuIniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePareceresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProcessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraçãoDeDadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_processos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.data_Processos = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_projetos = new System.Windows.Forms.ComboBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_addprojeto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_aprovar = new System.Windows.Forms.Label();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIniciarToolStripMenuItem,
            this.gestoresToolStripMenuItem,
            this.alteraçãoDeDadosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuIniciarToolStripMenuItem
            // 
            this.menuIniciarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuIniciarToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuIniciarToolStripMenuItem.Name = "menuIniciarToolStripMenuItem";
            this.menuIniciarToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.menuIniciarToolStripMenuItem.Text = "Menu Iniciar";
            this.menuIniciarToolStripMenuItem.Click += new System.EventHandler(this.menuIniciarToolStripMenuItem_Click);
            // 
            // gestoresToolStripMenuItem
            // 
            this.gestoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeFuncionáriosToolStripMenuItem,
            this.gestãoDePareceresToolStripMenuItem,
            this.gestãoDeProcessosToolStripMenuItem,
            this.gestãoDeProjetosToolStripMenuItem,
            this.gestãoDePromotoresToolStripMenuItem});
            this.gestoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestoresToolStripMenuItem.Name = "gestoresToolStripMenuItem";
            this.gestoresToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.gestoresToolStripMenuItem.Text = "Gestores";
            // 
            // gestãoDeFuncionáriosToolStripMenuItem
            // 
            this.gestãoDeFuncionáriosToolStripMenuItem.Name = "gestãoDeFuncionáriosToolStripMenuItem";
            this.gestãoDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.gestãoDeFuncionáriosToolStripMenuItem.Text = "Gestão de Funcionários";
            this.gestãoDeFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeFuncionáriosToolStripMenuItem_Click);
            // 
            // gestãoDePareceresToolStripMenuItem
            // 
            this.gestãoDePareceresToolStripMenuItem.Name = "gestãoDePareceresToolStripMenuItem";
            this.gestãoDePareceresToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.gestãoDePareceresToolStripMenuItem.Text = "Gestão de Pareceres";
            this.gestãoDePareceresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePareceresToolStripMenuItem_Click);
            // 
            // gestãoDeProcessosToolStripMenuItem
            // 
            this.gestãoDeProcessosToolStripMenuItem.Name = "gestãoDeProcessosToolStripMenuItem";
            this.gestãoDeProcessosToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.gestãoDeProcessosToolStripMenuItem.Text = "Gestão de Processos";
            this.gestãoDeProcessosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProcessosToolStripMenuItem_Click);
            // 
            // gestãoDeProjetosToolStripMenuItem
            // 
            this.gestãoDeProjetosToolStripMenuItem.Name = "gestãoDeProjetosToolStripMenuItem";
            this.gestãoDeProjetosToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.gestãoDeProjetosToolStripMenuItem.Text = "Gestão de Projetos";
            this.gestãoDeProjetosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProjetosToolStripMenuItem_Click);
            // 
            // gestãoDePromotoresToolStripMenuItem
            // 
            this.gestãoDePromotoresToolStripMenuItem.Name = "gestãoDePromotoresToolStripMenuItem";
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Gestão de Promotores";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // alteraçãoDeDadosToolStripMenuItem1
            // 
            this.alteraçãoDeDadosToolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.alteraçãoDeDadosToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alteraçãoDeDadosToolStripMenuItem1.Name = "alteraçãoDeDadosToolStripMenuItem1";
            this.alteraçãoDeDadosToolStripMenuItem1.Size = new System.Drawing.Size(129, 32);
            this.alteraçãoDeDadosToolStripMenuItem1.Text = "Promotores";
            this.alteraçãoDeDadosToolStripMenuItem1.Click += new System.EventHandler(this.alteraçãoDeDadosToolStripMenuItem1_Click);
            // 
            // listBox_processos
            // 
            this.listBox_processos.FormattingEnabled = true;
            this.listBox_processos.ItemHeight = 16;
            this.listBox_processos.Location = new System.Drawing.Point(577, 26);
            this.listBox_processos.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_processos.Name = "listBox_processos";
            this.listBox_processos.Size = new System.Drawing.Size(472, 388);
            this.listBox_processos.TabIndex = 0;
            this.listBox_processos.Click += new System.EventHandler(this.listBox_processos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 436);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(473, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Apagar Processo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Projetos incluídos no processo:";
            // 
            // data_Processos
            // 
            this.data_Processos.Location = new System.Drawing.Point(251, 142);
            this.data_Processos.Margin = new System.Windows.Forms.Padding(4);
            this.data_Processos.Name = "data_Processos";
            this.data_Processos.Size = new System.Drawing.Size(265, 22);
            this.data_Processos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de ínicio do processo:";
            // 
            // comboBox_projetos
            // 
            this.comboBox_projetos.FormattingEnabled = true;
            this.comboBox_projetos.Location = new System.Drawing.Point(223, 49);
            this.comboBox_projetos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_projetos.Name = "comboBox_projetos";
            this.comboBox_projetos.Size = new System.Drawing.Size(293, 24);
            this.comboBox_projetos.TabIndex = 9;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(27, 436);
            this.bt_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(473, 64);
            this.bt_guardar.TabIndex = 11;
            this.bt_guardar.Text = "Guardar processo";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_addprojeto
            // 
            this.bt_addprojeto.Location = new System.Drawing.Point(223, 82);
            this.bt_addprojeto.Margin = new System.Windows.Forms.Padding(4);
            this.bt_addprojeto.Name = "bt_addprojeto";
            this.bt_addprojeto.Size = new System.Drawing.Size(293, 26);
            this.bt_addprojeto.TabIndex = 12;
            this.bt_addprojeto.Text = "Adicionar projeto";
            this.bt_addprojeto.UseVisualStyleBackColor = true;
            this.bt_addprojeto.Click += new System.EventHandler(this.bt_addprojeto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_limpar);
            this.groupBox1.Controls.Add(this.label_aprovar);
            this.groupBox1.Controls.Add(this.bt_addprojeto);
            this.groupBox1.Controls.Add(this.bt_guardar);
            this.groupBox1.Controls.Add(this.comboBox_projetos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.data_Processos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listBox_processos);
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1067, 511);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão de Processos";
            // 
            // label_aprovar
            // 
            this.label_aprovar.AutoSize = true;
            this.label_aprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aprovar.Location = new System.Drawing.Point(79, 305);
            this.label_aprovar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_aprovar.Name = "label_aprovar";
            this.label_aprovar.Size = new System.Drawing.Size(174, 31);
            this.label_aprovar.TabIndex = 13;
            this.label_aprovar.Text = "[Por Aprovar]";
            this.label_aprovar.Visible = false;
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(428, 172);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(87, 34);
            this.bt_limpar.TabIndex = 14;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // GestaoProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestaoProcesso";
            this.Text = "GestãoProcessos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuIniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePareceresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoDeDadosToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox_processos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_Processos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_projetos;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_addprojeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_aprovar;
        private System.Windows.Forms.Button bt_limpar;
    }
}