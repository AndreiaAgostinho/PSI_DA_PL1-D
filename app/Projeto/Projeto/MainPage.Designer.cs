﻿
namespace Projeto
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btGestFunc = new System.Windows.Forms.Button();
            this.btGestaoProcessos = new System.Windows.Forms.Button();
            this.btGestaoPrometor = new System.Windows.Forms.Button();
            this.btGestaoProjetos = new System.Windows.Forms.Button();
            this.btGestaoPareceres = new System.Windows.Forms.Button();
            this.gestoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePareceresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProcessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-Vindo!";
            this.label1.DragOver += new System.Windows.Forms.DragEventHandler(this.True);
            // 
            // btGestFunc
            // 
            this.btGestFunc.Location = new System.Drawing.Point(31, 299);
            this.btGestFunc.Name = "btGestFunc";
            this.btGestFunc.Size = new System.Drawing.Size(124, 23);
            this.btGestFunc.TabIndex = 2;
            this.btGestFunc.Text = "Gestão Funcionários";
            this.btGestFunc.UseVisualStyleBackColor = true;
            this.btGestFunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btGestaoProcessos
            // 
            this.btGestaoProcessos.Location = new System.Drawing.Point(223, 299);
            this.btGestaoProcessos.Name = "btGestaoProcessos";
            this.btGestaoProcessos.Size = new System.Drawing.Size(124, 23);
            this.btGestaoProcessos.TabIndex = 3;
            this.btGestaoProcessos.Text = "Gestão de Processos";
            this.btGestaoProcessos.UseVisualStyleBackColor = true;
            this.btGestaoProcessos.Click += new System.EventHandler(this.btGestaoProcessos_Click);
            // 
            // btGestaoPrometor
            // 
            this.btGestaoPrometor.Location = new System.Drawing.Point(445, 299);
            this.btGestaoPrometor.Name = "btGestaoPrometor";
            this.btGestaoPrometor.Size = new System.Drawing.Size(124, 23);
            this.btGestaoPrometor.TabIndex = 4;
            this.btGestaoPrometor.Text = "Gestão de Promotores";
            this.btGestaoPrometor.UseVisualStyleBackColor = true;
            this.btGestaoPrometor.Click += new System.EventHandler(this.btGestaoPrometor_Click);
            // 
            // btGestaoProjetos
            // 
            this.btGestaoProjetos.Location = new System.Drawing.Point(854, 299);
            this.btGestaoProjetos.Name = "btGestaoProjetos";
            this.btGestaoProjetos.Size = new System.Drawing.Size(124, 23);
            this.btGestaoProjetos.TabIndex = 5;
            this.btGestaoProjetos.Text = "Gestão de Projetos";
            this.btGestaoProjetos.UseVisualStyleBackColor = true;
            this.btGestaoProjetos.Click += new System.EventHandler(this.btGestaoProjetos_Click);
            // 
            // btGestaoPareceres
            // 
            this.btGestaoPareceres.Location = new System.Drawing.Point(668, 299);
            this.btGestaoPareceres.Name = "btGestaoPareceres";
            this.btGestaoPareceres.Size = new System.Drawing.Size(124, 23);
            this.btGestaoPareceres.TabIndex = 6;
            this.btGestaoPareceres.Text = "Gestão de Pareceres";
            this.btGestaoPareceres.UseVisualStyleBackColor = true;
            this.btGestaoPareceres.Click += new System.EventHandler(this.btGestaoPareceres_Click);
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
            this.gestoresToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.gestoresToolStripMenuItem.Text = "Gestores";
            this.gestoresToolStripMenuItem.Click += new System.EventHandler(this.gestoresToolStripMenuItem_Click);
            // 
            // gestãoDeFuncionáriosToolStripMenuItem
            // 
            this.gestãoDeFuncionáriosToolStripMenuItem.Name = "gestãoDeFuncionáriosToolStripMenuItem";
            this.gestãoDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDeFuncionáriosToolStripMenuItem.Text = "Gestão de Funcionários";
            // 
            // gestãoDePareceresToolStripMenuItem
            // 
            this.gestãoDePareceresToolStripMenuItem.Name = "gestãoDePareceresToolStripMenuItem";
            this.gestãoDePareceresToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDePareceresToolStripMenuItem.Text = "Gestão de Pareceres";
            // 
            // gestãoDeProcessosToolStripMenuItem
            // 
            this.gestãoDeProcessosToolStripMenuItem.Name = "gestãoDeProcessosToolStripMenuItem";
            this.gestãoDeProcessosToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDeProcessosToolStripMenuItem.Text = "Gestão de Processos";
            // 
            // gestãoDeProjetosToolStripMenuItem
            // 
            this.gestãoDeProjetosToolStripMenuItem.Name = "gestãoDeProjetosToolStripMenuItem";
            this.gestãoDeProjetosToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDeProjetosToolStripMenuItem.Text = "Gestão de Projetos";
            // 
            // gestãoDePromotoresToolStripMenuItem
            // 
            this.gestãoDePromotoresToolStripMenuItem.Name = "gestãoDePromotoresToolStripMenuItem";
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Gestão de Promotores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 534);
            this.Controls.Add(this.btGestaoPareceres);
            this.Controls.Add(this.btGestaoProjetos);
            this.Controls.Add(this.btGestaoPrometor);
            this.Controls.Add(this.btGestaoProcessos);
            this.Controls.Add(this.btGestFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGestFunc;
        private System.Windows.Forms.Button btGestaoProcessos;
        private System.Windows.Forms.Button btGestaoPrometor;
        private System.Windows.Forms.Button btGestaoProjetos;
        private System.Windows.Forms.Button btGestaoPareceres;
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePareceresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}