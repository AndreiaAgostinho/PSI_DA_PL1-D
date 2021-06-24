
namespace Projeto
{
    partial class GestãoProjetosTodos
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
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_adicionar_projeto = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestoresToolStripMenuItem,
            this.menuIniciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestoresToolStripMenuItem
            // 
            this.gestoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeFuncionáriosToolStripMenuItem,
            this.gestãoDePareceresToolStripMenuItem,
            this.gestãoDeProcessosToolStripMenuItem,
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 368);
            this.dataGridView1.TabIndex = 1;
            // 
            // bt_adicionar_projeto
            // 
            this.bt_adicionar_projeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_adicionar_projeto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_adicionar_projeto.FlatAppearance.BorderSize = 0;
            this.bt_adicionar_projeto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_adicionar_projeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionar_projeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_adicionar_projeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_adicionar_projeto.Location = new System.Drawing.Point(12, 401);
            this.bt_adicionar_projeto.Name = "bt_adicionar_projeto";
            this.bt_adicionar_projeto.Size = new System.Drawing.Size(776, 47);
            this.bt_adicionar_projeto.TabIndex = 2;
            this.bt_adicionar_projeto.Text = "Adicionar Projeto";
            this.bt_adicionar_projeto.UseVisualStyleBackColor = false;
            this.bt_adicionar_projeto.Click += new System.EventHandler(this.bt_adicionar_projeto_Click);
            // 
            // GestãoProjetosTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_adicionar_projeto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestãoProjetosTodos";
            this.Text = "Gestão Projetos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePareceresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuIniciarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_adicionar_projeto;
    }
}