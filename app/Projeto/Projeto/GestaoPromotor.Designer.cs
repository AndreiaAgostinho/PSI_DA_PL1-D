
namespace Projeto
{
    partial class GestaoPromotore
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
            this.gestoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePareceresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProcessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.tb_senha_promotor = new System.Windows.Forms.TextBox();
            this.tb_codigo_acesso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_remover_promotor = new System.Windows.Forms.Button();
            this.tb_email_promotor = new System.Windows.Forms.TextBox();
            this.tb_telemovel_promotor = new System.Windows.Forms.TextBox();
            this.tb_nif_promotor = new System.Windows.Forms.TextBox();
            this.tb_morada_promotor = new System.Windows.Forms.TextBox();
            this.tb_nome_promotor = new System.Windows.Forms.TextBox();
            this.bt_guardar_promotor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listbox_promotor = new System.Windows.Forms.ListBox();
            this.bt_processo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestoresToolStripMenuItem,
            this.menuIniciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestoresToolStripMenuItem
            // 
            this.gestoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gestoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeFuncionáriosToolStripMenuItem,
            this.gestãoDePareceresToolStripMenuItem,
            this.gestãoDeProcessosToolStripMenuItem,
            this.gestãoDeProjetosToolStripMenuItem,
            this.gestãoDePromotoresToolStripMenuItem});
            this.gestoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestoresToolStripMenuItem.Name = "gestoresToolStripMenuItem";
            this.gestoresToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.gestoresToolStripMenuItem.Text = "Gestores";
            // 
            // gestãoDeFuncionáriosToolStripMenuItem
            // 
            this.gestãoDeFuncionáriosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gestãoDeFuncionáriosToolStripMenuItem.Name = "gestãoDeFuncionáriosToolStripMenuItem";
            this.gestãoDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDeFuncionáriosToolStripMenuItem.Text = "Gestão de Funcionários";
            this.gestãoDeFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeFuncionáriosToolStripMenuItem_Click);
            // 
            // gestãoDePareceresToolStripMenuItem
            // 
            this.gestãoDePareceresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gestãoDePareceresToolStripMenuItem.Name = "gestãoDePareceresToolStripMenuItem";
            this.gestãoDePareceresToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDePareceresToolStripMenuItem.Text = "Gestão de Pareceres";
            this.gestãoDePareceresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePareceresToolStripMenuItem_Click);
            // 
            // gestãoDeProcessosToolStripMenuItem
            // 
            this.gestãoDeProcessosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gestãoDeProcessosToolStripMenuItem.Name = "gestãoDeProcessosToolStripMenuItem";
            this.gestãoDeProcessosToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDeProcessosToolStripMenuItem.Text = "Gestão de Processos";
            this.gestãoDeProcessosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProcessosToolStripMenuItem_Click);
            // 
            // gestãoDeProjetosToolStripMenuItem
            // 
            this.gestãoDeProjetosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gestãoDeProjetosToolStripMenuItem.Name = "gestãoDeProjetosToolStripMenuItem";
            this.gestãoDeProjetosToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDeProjetosToolStripMenuItem.Text = "Gestão de Projetos";
            this.gestãoDeProjetosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProjetosToolStripMenuItem_Click);
            // 
            // gestãoDePromotoresToolStripMenuItem
            // 
            this.gestãoDePromotoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gestãoDePromotoresToolStripMenuItem.Name = "gestãoDePromotoresToolStripMenuItem";
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Gestão de Promotores";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // menuIniciarToolStripMenuItem
            // 
            this.menuIniciarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuIniciarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuIniciarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuIniciarToolStripMenuItem.Name = "menuIniciarToolStripMenuItem";
            this.menuIniciarToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.menuIniciarToolStripMenuItem.Text = "Menu Iniciar";
            this.menuIniciarToolStripMenuItem.Click += new System.EventHandler(this.menuIniciarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_limpar);
            this.groupBox1.Controls.Add(this.tb_senha_promotor);
            this.groupBox1.Controls.Add(this.tb_codigo_acesso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bt_remover_promotor);
            this.groupBox1.Controls.Add(this.tb_email_promotor);
            this.groupBox1.Controls.Add(this.tb_telemovel_promotor);
            this.groupBox1.Controls.Add(this.tb_nif_promotor);
            this.groupBox1.Controls.Add(this.tb_morada_promotor);
            this.groupBox1.Controls.Add(this.tb_nome_promotor);
            this.groupBox1.Controls.Add(this.bt_guardar_promotor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Promotor";
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_limpar.FlatAppearance.BorderSize = 0;
            this.bt_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_limpar.Location = new System.Drawing.Point(348, 298);
            this.bt_limpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(56, 21);
            this.bt_limpar.TabIndex = 15;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // tb_senha_promotor
            // 
            this.tb_senha_promotor.Location = new System.Drawing.Point(60, 274);
            this.tb_senha_promotor.Name = "tb_senha_promotor";
            this.tb_senha_promotor.Size = new System.Drawing.Size(346, 20);
            this.tb_senha_promotor.TabIndex = 14;
            // 
            // tb_codigo_acesso
            // 
            this.tb_codigo_acesso.Location = new System.Drawing.Point(90, 239);
            this.tb_codigo_acesso.Name = "tb_codigo_acesso";
            this.tb_codigo_acesso.Size = new System.Drawing.Size(316, 20);
            this.tb_codigo_acesso.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código Acesso:";
            // 
            // bt_remover_promotor
            // 
            this.bt_remover_promotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_remover_promotor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_remover_promotor.FlatAppearance.BorderSize = 0;
            this.bt_remover_promotor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_remover_promotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover_promotor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_remover_promotor.Location = new System.Drawing.Point(19, 364);
            this.bt_remover_promotor.Name = "bt_remover_promotor";
            this.bt_remover_promotor.Size = new System.Drawing.Size(387, 23);
            this.bt_remover_promotor.TabIndex = 10;
            this.bt_remover_promotor.Text = "Remover Promotor";
            this.bt_remover_promotor.UseVisualStyleBackColor = false;
            // 
            // tb_email_promotor
            // 
            this.tb_email_promotor.Location = new System.Drawing.Point(60, 198);
            this.tb_email_promotor.Name = "tb_email_promotor";
            this.tb_email_promotor.Size = new System.Drawing.Size(346, 20);
            this.tb_email_promotor.TabIndex = 9;
            // 
            // tb_telemovel_promotor
            // 
            this.tb_telemovel_promotor.Location = new System.Drawing.Point(60, 157);
            this.tb_telemovel_promotor.MaxLength = 15;
            this.tb_telemovel_promotor.Name = "tb_telemovel_promotor";
            this.tb_telemovel_promotor.Size = new System.Drawing.Size(346, 20);
            this.tb_telemovel_promotor.TabIndex = 8;
            this.tb_telemovel_promotor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_telemovel_promotor_KeyPress);
            // 
            // tb_nif_promotor
            // 
            this.tb_nif_promotor.Location = new System.Drawing.Point(60, 112);
            this.tb_nif_promotor.MaxLength = 9;
            this.tb_nif_promotor.Name = "tb_nif_promotor";
            this.tb_nif_promotor.Size = new System.Drawing.Size(346, 20);
            this.tb_nif_promotor.TabIndex = 7;
            this.tb_nif_promotor.TextChanged += new System.EventHandler(this.tb_nif_promotor_TextChanged);
            this.tb_nif_promotor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nif_promotor_KeyPress);
            // 
            // tb_morada_promotor
            // 
            this.tb_morada_promotor.Location = new System.Drawing.Point(60, 70);
            this.tb_morada_promotor.Name = "tb_morada_promotor";
            this.tb_morada_promotor.Size = new System.Drawing.Size(346, 20);
            this.tb_morada_promotor.TabIndex = 6;
            this.tb_morada_promotor.TextChanged += new System.EventHandler(this.tb_morada_promotor_TextChanged);
            // 
            // tb_nome_promotor
            // 
            this.tb_nome_promotor.Location = new System.Drawing.Point(60, 30);
            this.tb_nome_promotor.Name = "tb_nome_promotor";
            this.tb_nome_promotor.Size = new System.Drawing.Size(346, 20);
            this.tb_nome_promotor.TabIndex = 5;
            this.tb_nome_promotor.TextChanged += new System.EventHandler(this.tb_nome_promotor_TextChanged);
            // 
            // bt_guardar_promotor
            // 
            this.bt_guardar_promotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_guardar_promotor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_guardar_promotor.FlatAppearance.BorderSize = 0;
            this.bt_guardar_promotor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_guardar_promotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar_promotor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_guardar_promotor.Location = new System.Drawing.Point(19, 335);
            this.bt_guardar_promotor.Name = "bt_guardar_promotor";
            this.bt_guardar_promotor.Size = new System.Drawing.Size(387, 23);
            this.bt_guardar_promotor.TabIndex = 2;
            this.bt_guardar_promotor.Text = "Guardar Promotor";
            this.bt_guardar_promotor.UseVisualStyleBackColor = false;
            this.bt_guardar_promotor.Click += new System.EventHandler(this.bt_guardar_promotor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Morada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIF:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telemóvel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listbox_promotor);
            this.groupBox2.Controls.Add(this.bt_processo);
            this.groupBox2.Location = new System.Drawing.Point(430, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 406);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar Promotor";
            // 
            // listbox_promotor
            // 
            this.listbox_promotor.FormattingEnabled = true;
            this.listbox_promotor.Location = new System.Drawing.Point(6, 16);
            this.listbox_promotor.Name = "listbox_promotor";
            this.listbox_promotor.Size = new System.Drawing.Size(346, 342);
            this.listbox_promotor.TabIndex = 2;
            this.listbox_promotor.Click += new System.EventHandler(this.listbox_promotor_Click);
            // 
            // bt_processo
            // 
            this.bt_processo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_processo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_processo.FlatAppearance.BorderSize = 0;
            this.bt_processo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_processo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_processo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_processo.Location = new System.Drawing.Point(6, 364);
            this.bt_processo.Name = "bt_processo";
            this.bt_processo.Size = new System.Drawing.Size(346, 23);
            this.bt_processo.TabIndex = 1;
            this.bt_processo.Text = "Ver Processos";
            this.bt_processo.UseVisualStyleBackColor = false;
            this.bt_processo.Click += new System.EventHandler(this.bt_processo_Click);
            // 
            // GestaoPromotore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestaoPromotore";
            this.Text = "GestaoPromotores";
            this.Load += new System.EventHandler(this.GestaoPromotores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePareceresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuIniciarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email_promotor;
        private System.Windows.Forms.TextBox tb_telemovel_promotor;
        private System.Windows.Forms.TextBox tb_nif_promotor;
        private System.Windows.Forms.TextBox tb_morada_promotor;
        private System.Windows.Forms.TextBox tb_nome_promotor;
        private System.Windows.Forms.Button bt_guardar_promotor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_processo;
        private System.Windows.Forms.Button bt_remover_promotor;
        private System.Windows.Forms.TextBox tb_senha_promotor;
        private System.Windows.Forms.TextBox tb_codigo_acesso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listbox_promotor;
        private System.Windows.Forms.Button bt_limpar;
    }
}