namespace View.UI.ViewProduto
{
    partial class frmMovimentacaoProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaoProdutos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbPesquisarDia = new System.Windows.Forms.GroupBox();
            this.btnPesquisarDia = new System.Windows.Forms.Button();
            this.dtpPesquisarPorDia = new System.Windows.Forms.DateTimePicker();
            this.btnTodos = new System.Windows.Forms.Button();
            this.lblTotalLucro = new System.Windows.Forms.Label();
            this.txtTotalLucro = new System.Windows.Forms.TextBox();
            this.gpbDatas = new System.Windows.Forms.GroupBox();
            this.btnPesquisarEntreDatas = new System.Windows.Forms.Button();
            this.dtpValorFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpValorInicial = new System.Windows.Forms.DateTimePicker();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.gpbPesquisarDia.SuspendLayout();
            this.gpbDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPesquisarDia
            // 
            this.gpbPesquisarDia.Controls.Add(this.btnPesquisarDia);
            this.gpbPesquisarDia.Controls.Add(this.dtpPesquisarPorDia);
            this.gpbPesquisarDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarDia.Location = new System.Drawing.Point(293, 1);
            this.gpbPesquisarDia.Name = "gpbPesquisarDia";
            this.gpbPesquisarDia.Size = new System.Drawing.Size(245, 75);
            this.gpbPesquisarDia.TabIndex = 28;
            this.gpbPesquisarDia.TabStop = false;
            this.gpbPesquisarDia.Text = "Pesquisar por dia";
            // 
            // btnPesquisarDia
            // 
            this.btnPesquisarDia.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarDia.Image")));
            this.btnPesquisarDia.Location = new System.Drawing.Point(143, 8);
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
            this.dtpPesquisarPorDia.Location = new System.Drawing.Point(25, 33);
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
            this.btnTodos.Location = new System.Drawing.Point(7, 9);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(280, 64);
            this.btnTodos.TabIndex = 1;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            // 
            // lblTotalLucro
            // 
            this.lblTotalLucro.AutoSize = true;
            this.lblTotalLucro.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLucro.Location = new System.Drawing.Point(7, 167);
            this.lblTotalLucro.Name = "lblTotalLucro";
            this.lblTotalLucro.Size = new System.Drawing.Size(188, 33);
            this.lblTotalLucro.TabIndex = 27;
            this.lblTotalLucro.Text = "Valor Total";
            // 
            // txtTotalLucro
            // 
            this.txtTotalLucro.BackColor = System.Drawing.Color.Lime;
            this.txtTotalLucro.Enabled = false;
            this.txtTotalLucro.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLucro.Location = new System.Drawing.Point(206, 164);
            this.txtTotalLucro.MaxLength = 100;
            this.txtTotalLucro.Name = "txtTotalLucro";
            this.txtTotalLucro.ReadOnly = true;
            this.txtTotalLucro.Size = new System.Drawing.Size(332, 41);
            this.txtTotalLucro.TabIndex = 26;
            this.txtTotalLucro.TabStop = false;
            this.txtTotalLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbDatas
            // 
            this.gpbDatas.Controls.Add(this.btnPesquisarEntreDatas);
            this.gpbDatas.Controls.Add(this.dtpValorFinal);
            this.gpbDatas.Controls.Add(this.dtpValorInicial);
            this.gpbDatas.Controls.Add(this.lblValorFinal);
            this.gpbDatas.Controls.Add(this.lblValorInicial);
            this.gpbDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatas.Location = new System.Drawing.Point(7, 83);
            this.gpbDatas.Name = "gpbDatas";
            this.gpbDatas.Size = new System.Drawing.Size(531, 75);
            this.gpbDatas.TabIndex = 25;
            this.gpbDatas.TabStop = false;
            this.gpbDatas.Text = "Pesquisar movimentações";
            // 
            // btnPesquisarEntreDatas
            // 
            this.btnPesquisarEntreDatas.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarEntreDatas.Image")));
            this.btnPesquisarEntreDatas.Location = new System.Drawing.Point(429, 9);
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
            this.dtpValorFinal.Location = new System.Drawing.Point(311, 33);
            this.dtpValorFinal.Name = "dtpValorFinal";
            this.dtpValorFinal.Size = new System.Drawing.Size(112, 26);
            this.dtpValorFinal.TabIndex = 3;
            this.dtpValorFinal.TabStop = false;
            // 
            // dtpValorInicial
            // 
            this.dtpValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpValorInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValorInicial.Location = new System.Drawing.Point(141, 31);
            this.dtpValorInicial.Name = "dtpValorInicial";
            this.dtpValorInicial.Size = new System.Drawing.Size(128, 26);
            this.dtpValorInicial.TabIndex = 2;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.Location = new System.Drawing.Point(278, 37);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(31, 16);
            this.lblValorFinal.TabIndex = 6;
            this.lblValorFinal.Text = "Até:";
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.Location = new System.Drawing.Point(19, 34);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(119, 16);
            this.lblValorInicial.TabIndex = 5;
            this.lblValorInicial.Text = "Movimentação de:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(206, 215);
            this.txtQuantidade.MaxLength = 100;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(332, 41);
            this.txtQuantidade.TabIndex = 26;
            this.txtQuantidade.TabStop = false;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(7, 218);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(187, 33);
            this.lblQuantidade.TabIndex = 27;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowDrop = true;
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeight = 40;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Location = new System.Drawing.Point(7, 262);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 40;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(531, 222);
            this.dgvProdutos.TabIndex = 29;
            this.dgvProdutos.TabStop = false;
            this.dgvProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProdutos_KeyDown);
            // 
            // frmMovimentacaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 496);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.gpbPesquisarDia);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblTotalLucro);
            this.Controls.Add(this.txtTotalLucro);
            this.Controls.Add(this.gpbDatas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentacaoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de Produtos";
            this.Load += new System.EventHandler(this.frmMovimentacaoProdutos_Load);
            this.gpbPesquisarDia.ResumeLayout(false);
            this.gpbDatas.ResumeLayout(false);
            this.gpbDatas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
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
        private System.Windows.Forms.GroupBox gpbDatas;
        private System.Windows.Forms.Button btnPesquisarEntreDatas;
        private System.Windows.Forms.DateTimePicker dtpValorFinal;
        private System.Windows.Forms.DateTimePicker dtpValorInicial;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblValorInicial;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}