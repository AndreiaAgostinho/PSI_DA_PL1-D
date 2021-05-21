
namespace Projeto
{
    partial class GestaoFuncionariosInicial
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
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraçãoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraçãoDeDadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.alteraçãoDeDadosToolStripMenuItem,
            this.alteraçãoDeDadosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.voltarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.voltarToolStripMenuItem.Text = "Registo";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // alteraçãoDeDadosToolStripMenuItem
            // 
            this.alteraçãoDeDadosToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.alteraçãoDeDadosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alteraçãoDeDadosToolStripMenuItem.Name = "alteraçãoDeDadosToolStripMenuItem";
            this.alteraçãoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(130, 25);
            this.alteraçãoDeDadosToolStripMenuItem.Text = "Acesso a Dados";
            // 
            // alteraçãoDeDadosToolStripMenuItem1
            // 
            this.alteraçãoDeDadosToolStripMenuItem1.BackColor = System.Drawing.Color.PaleGreen;
            this.alteraçãoDeDadosToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alteraçãoDeDadosToolStripMenuItem1.Name = "alteraçãoDeDadosToolStripMenuItem1";
            this.alteraçãoDeDadosToolStripMenuItem1.Size = new System.Drawing.Size(156, 25);
            this.alteraçãoDeDadosToolStripMenuItem1.Text = "Alteração de Dados";
            // 
            // GestaoFuncionariosInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GestaoFuncionariosInicial";
            this.Text = "GestãoFuncionários";
            this.Load += new System.EventHandler(this.GestaoFuncionariosInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoDeDadosToolStripMenuItem1;
    }
}