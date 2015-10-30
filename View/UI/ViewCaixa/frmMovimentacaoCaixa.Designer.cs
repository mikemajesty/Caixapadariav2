namespace View.UI.ViewCaixa
{
    partial class frmMovimentacaoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaoCaixa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbPesquisarDia = new System.Windows.Forms.GroupBox();
            this.btnPesquisarDia = new System.Windows.Forms.Button();
            this.dtpPesquisarPorDia = new System.Windows.Forms.DateTimePicker();
            this.btnTodos = new System.Windows.Forms.Button();
            this.lblTotalLucro = new System.Windows.Forms.Label();
            this.txtTotalLucro = new System.Windows.Forms.TextBox();
            this.dgvMovimentacao = new System.Windows.Forms.DataGridView();
            this.gpbDatas = new System.Windows.Forms.GroupBox();
            this.btnPesquisarEntreDatas = new System.Windows.Forms.Button();
            this.dtpValorFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpValorInicial = new System.Windows.Forms.DateTimePicker();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.gpbPesquisarDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacao)).BeginInit();
            this.gpbDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarDia
            // 
            this.gpbPesquisarDia.Controls.Add(this.btnPesquisarDia);
            this.gpbPesquisarDia.Controls.Add(this.dtpPesquisarPorDia);
            this.gpbPesquisarDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarDia.Location = new System.Drawing.Point(298, 12);
            this.gpbPesquisarDia.Name = "gpbPesquisarDia";
            this.gpbPesquisarDia.Size = new System.Drawing.Size(223, 75);
            this.gpbPesquisarDia.TabIndex = 23;
            this.gpbPesquisarDia.TabStop = false;
            this.gpbPesquisarDia.Text = "Pesquisar por dia";
            // 
            // btnPesquisarDia
            // 
            this.btnPesquisarDia.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarDia.Image")));
            this.btnPesquisarDia.Location = new System.Drawing.Point(128, 12);
            this.btnPesquisarDia.Name = "btnPesquisarDia";
            this.btnPesquisarDia.Size = new System.Drawing.Size(86, 60);
            this.btnPesquisarDia.TabIndex = 2;
            this.btnPesquisarDia.UseVisualStyleBackColor = true;
            this.btnPesquisarDia.Click += new System.EventHandler(this.btnPesquisarDia_Click);
            // 
            // dtpPesquisarPorDia
            // 
            this.dtpPesquisarPorDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPesquisarPorDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesquisarPorDia.Location = new System.Drawing.Point(10, 37);
            this.dtpPesquisarPorDia.Name = "dtpPesquisarPorDia";
            this.dtpPesquisarPorDia.Size = new System.Drawing.Size(112, 26);
            this.dtpPesquisarPorDia.TabIndex = 2;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.Yellow;
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(12, 20);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(280, 64);
            this.btnTodos.TabIndex = 1;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // lblTotalLucro
            // 
            this.lblTotalLucro.AutoSize = true;
            this.lblTotalLucro.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLucro.Location = new System.Drawing.Point(12, 178);
            this.lblTotalLucro.Name = "lblTotalLucro";
            this.lblTotalLucro.Size = new System.Drawing.Size(188, 33);
            this.lblTotalLucro.TabIndex = 21;
            this.lblTotalLucro.Text = "Valor Total";
            // 
            // txtTotalLucro
            // 
            this.txtTotalLucro.BackColor = System.Drawing.Color.Lime;
            this.txtTotalLucro.Enabled = false;
            this.txtTotalLucro.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLucro.Location = new System.Drawing.Point(211, 175);
            this.txtTotalLucro.Name = "txtTotalLucro";
            this.txtTotalLucro.ReadOnly = true;
            this.txtTotalLucro.Size = new System.Drawing.Size(310, 41);
            this.txtTotalLucro.TabIndex = 19;
            this.txtTotalLucro.TabStop = false;
            this.txtTotalLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvMovimentacao
            // 
            this.dgvMovimentacao.AllowDrop = true;
            this.dgvMovimentacao.AllowUserToAddRows = false;
            this.dgvMovimentacao.AllowUserToDeleteRows = false;
            this.dgvMovimentacao.AllowUserToResizeColumns = false;
            this.dgvMovimentacao.AllowUserToResizeRows = false;
            this.dgvMovimentacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimentacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovimentacao.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimentacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimentacao.ColumnHeadersHeight = 40;
            this.dgvMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimentacao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovimentacao.Location = new System.Drawing.Point(12, 222);
            this.dgvMovimentacao.MultiSelect = false;
            this.dgvMovimentacao.Name = "dgvMovimentacao";
            this.dgvMovimentacao.ReadOnly = true;
            this.dgvMovimentacao.RowHeadersVisible = false;
            this.dgvMovimentacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimentacao.Size = new System.Drawing.Size(509, 210);
            this.dgvMovimentacao.TabIndex = 18;
            this.dgvMovimentacao.TabStop = false;
            this.dgvMovimentacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMovimentacao_KeyDown);
            // 
            // gpbDatas
            // 
            this.gpbDatas.Controls.Add(this.btnPesquisarEntreDatas);
            this.gpbDatas.Controls.Add(this.dtpValorFinal);
            this.gpbDatas.Controls.Add(this.dtpValorInicial);
            this.gpbDatas.Controls.Add(this.lblValorFinal);
            this.gpbDatas.Controls.Add(this.lblValorInicial);
            this.gpbDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatas.Location = new System.Drawing.Point(12, 94);
            this.gpbDatas.Name = "gpbDatas";
            this.gpbDatas.Size = new System.Drawing.Size(509, 75);
            this.gpbDatas.TabIndex = 16;
            this.gpbDatas.TabStop = false;
            this.gpbDatas.Text = "Pesquisar movimentações";
            // 
            // btnPesquisarEntreDatas
            // 
            this.btnPesquisarEntreDatas.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarEntreDatas.Image")));
            this.btnPesquisarEntreDatas.Location = new System.Drawing.Point(414, 12);
            this.btnPesquisarEntreDatas.Name = "btnPesquisarEntreDatas";
            this.btnPesquisarEntreDatas.Size = new System.Drawing.Size(86, 60);
            this.btnPesquisarEntreDatas.TabIndex = 3;
            this.btnPesquisarEntreDatas.UseVisualStyleBackColor = true;
            this.btnPesquisarEntreDatas.Click += new System.EventHandler(this.btnPesquisarEntreDatas_Click);
            // 
            // dtpValorFinal
            // 
            this.dtpValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpValorFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValorFinal.Location = new System.Drawing.Point(296, 36);
            this.dtpValorFinal.Name = "dtpValorFinal";
            this.dtpValorFinal.Size = new System.Drawing.Size(112, 26);
            this.dtpValorFinal.TabIndex = 3;
            this.dtpValorFinal.TabStop = false;
            // 
            // dtpValorInicial
            // 
            this.dtpValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpValorInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValorInicial.Location = new System.Drawing.Point(129, 37);
            this.dtpValorInicial.Name = "dtpValorInicial";
            this.dtpValorInicial.Size = new System.Drawing.Size(128, 26);
            this.dtpValorInicial.TabIndex = 2;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.Location = new System.Drawing.Point(263, 40);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(31, 16);
            this.lblValorFinal.TabIndex = 6;
            this.lblValorFinal.Text = "Até:";
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.Location = new System.Drawing.Point(7, 40);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(119, 16);
            this.lblValorInicial.TabIndex = 5;
            this.lblValorInicial.Text = "Movimentação de:";
            // 
            // frmMovimentacaoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 440);
            this.Controls.Add(this.gpbPesquisarDia);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.lblTotalLucro);
            this.Controls.Add(this.txtTotalLucro);
            this.Controls.Add(this.dgvMovimentacao);
            this.Controls.Add(this.gpbDatas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentacaoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação do Caixa";
            this.Load += new System.EventHandler(this.frmMovimentacaoCaixa_Load);
            this.gpbPesquisarDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacao)).EndInit();
            this.gpbDatas.ResumeLayout(false);
            this.gpbDatas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarDia;
        private System.Windows.Forms.Button btnPesquisarDia;
        private System.Windows.Forms.DateTimePicker dtpPesquisarPorDia;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label lblTotalLucro;
        private System.Windows.Forms.TextBox txtTotalLucro;
        private System.Windows.Forms.DataGridView dgvMovimentacao;
        private System.Windows.Forms.GroupBox gpbDatas;
        private System.Windows.Forms.Button btnPesquisarEntreDatas;
        private System.Windows.Forms.DateTimePicker dtpValorFinal;
        private System.Windows.Forms.DateTimePicker dtpValorInicial;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblValorInicial;
    }
}