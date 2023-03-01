namespace ControleGastoAppWin
{
    partial class frmAnalise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalise));
            this.lblNome = new System.Windows.Forms.Label();
            this.cbxNome = new System.Windows.Forms.ComboBox();
            this.dgvReceita = new System.Windows.Forms.DataGridView();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.lblReceita = new System.Windows.Forms.Label();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.lblTotalReceita = new System.Windows.Forms.Label();
            this.lblTotalDespesa = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTotalSaldo = new System.Windows.Forms.Label();
            this.lblAnalise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.Khaki;
            this.lblNome.Location = new System.Drawing.Point(223, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME";
            // 
            // cbxNome
            // 
            this.cbxNome.FormattingEnabled = true;
            this.cbxNome.Location = new System.Drawing.Point(283, 59);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(249, 23);
            this.cbxNome.TabIndex = 1;
            // 
            // dgvReceita
            // 
            this.dgvReceita.BackgroundColor = System.Drawing.Color.Black;
            this.dgvReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceita.Location = new System.Drawing.Point(94, 121);
            this.dgvReceita.Name = "dgvReceita";
            this.dgvReceita.RowTemplate.Height = 25;
            this.dgvReceita.Size = new System.Drawing.Size(242, 235);
            this.dgvReceita.TabIndex = 2;
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.BackgroundColor = System.Drawing.Color.Black;
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Location = new System.Drawing.Point(510, 121);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.RowTemplate.Height = 25;
            this.dgvDespesa.Size = new System.Drawing.Size(242, 235);
            this.dgvDespesa.TabIndex = 3;
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.BackColor = System.Drawing.Color.Transparent;
            this.lblReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReceita.ForeColor = System.Drawing.Color.Khaki;
            this.lblReceita.Location = new System.Drawing.Point(94, 359);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(122, 21);
            this.lblReceita.TabIndex = 4;
            this.lblReceita.Text = "TOTAL RECEITA";
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.BackColor = System.Drawing.Color.Transparent;
            this.lblDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDespesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDespesa.ForeColor = System.Drawing.Color.Khaki;
            this.lblDespesa.Location = new System.Drawing.Point(510, 359);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(129, 21);
            this.lblDespesa.TabIndex = 5;
            this.lblDespesa.Text = "TOTAL DESPESA";
            // 
            // lblTotalReceita
            // 
            this.lblTotalReceita.AutoSize = true;
            this.lblTotalReceita.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalReceita.ForeColor = System.Drawing.Color.Khaki;
            this.lblTotalReceita.Location = new System.Drawing.Point(295, 359);
            this.lblTotalReceita.Name = "lblTotalReceita";
            this.lblTotalReceita.Size = new System.Drawing.Size(41, 21);
            this.lblTotalReceita.TabIndex = 6;
            this.lblTotalReceita.Text = "0,00";
            // 
            // lblTotalDespesa
            // 
            this.lblTotalDespesa.AutoSize = true;
            this.lblTotalDespesa.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalDespesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDespesa.ForeColor = System.Drawing.Color.Khaki;
            this.lblTotalDespesa.Location = new System.Drawing.Point(711, 359);
            this.lblTotalDespesa.Name = "lblTotalDespesa";
            this.lblTotalDespesa.Size = new System.Drawing.Size(41, 21);
            this.lblTotalDespesa.TabIndex = 7;
            this.lblTotalDespesa.Text = "0,00";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Khaki;
            this.btnPesquisar.Location = new System.Drawing.Point(538, 58);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 24);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.ForeColor = System.Drawing.Color.Khaki;
            this.lblSaldo.Location = new System.Drawing.Point(94, 415);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(96, 37);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblTotalSaldo
            // 
            this.lblTotalSaldo.AutoSize = true;
            this.lblTotalSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalSaldo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSaldo.ForeColor = System.Drawing.Color.Khaki;
            this.lblTotalSaldo.Location = new System.Drawing.Point(220, 415);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Size = new System.Drawing.Size(72, 37);
            this.lblTotalSaldo.TabIndex = 10;
            this.lblTotalSaldo.Text = "0,00";
            // 
            // lblAnalise
            // 
            this.lblAnalise.AutoSize = true;
            this.lblAnalise.BackColor = System.Drawing.Color.Transparent;
            this.lblAnalise.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAnalise.ForeColor = System.Drawing.Color.Khaki;
            this.lblAnalise.Location = new System.Drawing.Point(361, 9);
            this.lblAnalise.Name = "lblAnalise";
            this.lblAnalise.Size = new System.Drawing.Size(128, 37);
            this.lblAnalise.TabIndex = 11;
            this.lblAnalise.Text = "ANÁLISE";
            // 
            // frmAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lblAnalise);
            this.Controls.Add(this.lblTotalSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblTotalDespesa);
            this.Controls.Add(this.lblTotalReceita);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.lblReceita);
            this.Controls.Add(this.dgvDespesa);
            this.Controls.Add(this.dgvReceita);
            this.Controls.Add(this.cbxNome);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnalise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbxNome;
        private System.Windows.Forms.DataGridView dgvReceita;
        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label lblTotalReceita;
        private System.Windows.Forms.Label lblTotalDespesa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTotalSaldo;
        private System.Windows.Forms.Label lblAnalise;
    }
}