
namespace Projeto
{
    partial class GestãoPromotoresTodos
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
            this.dataGridView_promotores = new System.Windows.Forms.DataGridView();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telemovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePareceresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProcessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_adicionar_promotor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_promotores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_promotores
            // 
            this.dataGridView_promotores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_promotores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIF,
            this.Nome,
            this.Morada,
            this.Telemovel,
            this.Email,
            this.CodigoAcesso,
            this.Processos});
            this.dataGridView_promotores.Location = new System.Drawing.Point(10, 38);
            this.dataGridView_promotores.Name = "dataGridView_promotores";
            this.dataGridView_promotores.ReadOnly = true;
            this.dataGridView_promotores.RowHeadersWidth = 51;
            this.dataGridView_promotores.Size = new System.Drawing.Size(776, 364);
            this.dataGridView_promotores.TabIndex = 3;
            this.dataGridView_promotores.Click += new System.EventHandler(this.dataGridView_promotores_Click);
            // 
            // NIF
            // 
            this.NIF.HeaderText = "NIF";
            this.NIF.MinimumWidth = 6;
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            this.NIF.Width = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // Morada
            // 
            this.Morada.HeaderText = "Morada";
            this.Morada.MinimumWidth = 6;
            this.Morada.Name = "Morada";
            this.Morada.ReadOnly = true;
            this.Morada.Width = 125;
            // 
            // Telemovel
            // 
            this.Telemovel.HeaderText = "Telemovel";
            this.Telemovel.MinimumWidth = 6;
            this.Telemovel.Name = "Telemovel";
            this.Telemovel.ReadOnly = true;
            this.Telemovel.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // CodigoAcesso
            // 
            this.CodigoAcesso.HeaderText = "Codigo de Acesso";
            this.CodigoAcesso.MinimumWidth = 6;
            this.CodigoAcesso.Name = "CodigoAcesso";
            this.CodigoAcesso.ReadOnly = true;
            this.CodigoAcesso.Width = 125;
            // 
            // Processos
            // 
            this.Processos.HeaderText = "Número de Processos";
            this.Processos.MinimumWidth = 6;
            this.Processos.Name = "Processos";
            this.Processos.ReadOnly = true;
            this.Processos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Processos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Processos.Width = 125;
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
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestoresToolStripMenuItem
            // 
            this.gestoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gestoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeFuncionáriosToolStripMenuItem,
            this.gestãoDePareceresToolStripMenuItem,
            this.gestãoDeProcessosToolStripMenuItem,
            this.gestãoDeProjetosToolStripMenuItem});
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
            // bt_adicionar_promotor
            // 
            this.bt_adicionar_promotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_adicionar_promotor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_adicionar_promotor.FlatAppearance.BorderSize = 0;
            this.bt_adicionar_promotor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_adicionar_promotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionar_promotor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_adicionar_promotor.Location = new System.Drawing.Point(12, 408);
            this.bt_adicionar_promotor.Name = "bt_adicionar_promotor";
            this.bt_adicionar_promotor.Size = new System.Drawing.Size(776, 37);
            this.bt_adicionar_promotor.TabIndex = 4;
            this.bt_adicionar_promotor.Text = "Adicionar Promotor";
            this.bt_adicionar_promotor.UseVisualStyleBackColor = false;
            this.bt_adicionar_promotor.Click += new System.EventHandler(this.bt_adicionar_promotor_Click);
            // 
            // GestãoPromotoresTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_adicionar_promotor);
            this.Controls.Add(this.dataGridView_promotores);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GestãoPromotoresTodos";
            this.Text = "GestãoPromotoresTodos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_promotores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_promotores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePareceresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuIniciarToolStripMenuItem;
        private System.Windows.Forms.Button bt_adicionar_promotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telemovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAcesso;
        private System.Windows.Forms.DataGridViewButtonColumn Processos;
    }
}