namespace View.UI.ViewCaixa
{
    partial class frmDividirComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDividirComanda));
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.gpbGerarParcelas = new System.Windows.Forms.GroupBox();
            this.gpbNumeroDeParcelas = new System.Windows.Forms.GroupBox();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNumeroDeParcelas = new System.Windows.Forms.TextBox();
            this.gpbTipoDePagamento = new System.Windows.Forms.GroupBox();
            this.cbbTipoDePagamento = new System.Windows.Forms.ComboBox();
            this.gpbGerarTroco = new System.Windows.Forms.GroupBox();
            this.ptbTroco = new System.Windows.Forms.PictureBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.gpbValorPago = new System.Windows.Forms.GroupBox();
            this.ptbValorTotalPago = new System.Windows.Forms.PictureBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.gpbTotalDaParcela = new System.Windows.Forms.GroupBox();
            this.lblTotalPorParcela = new System.Windows.Forms.Label();
            this.gpbTotalDaVenda = new System.Windows.Forms.GroupBox();
            this.lblTotalDaComanda = new System.Windows.Forms.Label();
            this.MenuCaixa = new System.Windows.Forms.MenuStrip();
            this.menuOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMudarParcelas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrirCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.lblValorCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbGerarParcelas.SuspendLayout();
            this.gpbNumeroDeParcelas.SuspendLayout();
            this.gpbTipoDePagamento.SuspendLayout();
            this.gpbGerarTroco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroco)).BeginInit();
            this.gpbValorPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbValorTotalPago)).BeginInit();
            this.gpbTotalDaParcela.SuspendLayout();
            this.gpbTotalDaVenda.SuspendLayout();
            this.MenuCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Location = new System.Drawing.Point(6, 19);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(188, 75);
            this.btnGerarParcelas.TabIndex = 0;
            this.btnGerarParcelas.Text = "Parcelar";
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // gpbGerarParcelas
            // 
            this.gpbGerarParcelas.Controls.Add(this.btnGerarParcelas);
            this.gpbGerarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGerarParcelas.Location = new System.Drawing.Point(12, 58);
            this.gpbGerarParcelas.Name = "gpbGerarParcelas";
            this.gpbGerarParcelas.Size = new System.Drawing.Size(200, 100);
            this.gpbGerarParcelas.TabIndex = 1;
            this.gpbGerarParcelas.TabStop = false;
            this.gpbGerarParcelas.Text = "Gerar parcelas";
            // 
            // gpbNumeroDeParcelas
            // 
            this.gpbNumeroDeParcelas.Controls.Add(this.btnSubtrair);
            this.gpbNumeroDeParcelas.Controls.Add(this.btnAdicionar);
            this.gpbNumeroDeParcelas.Controls.Add(this.txtNumeroDeParcelas);
            this.gpbNumeroDeParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNumeroDeParcelas.Location = new System.Drawing.Point(229, 58);
            this.gpbNumeroDeParcelas.Name = "gpbNumeroDeParcelas";
            this.gpbNumeroDeParcelas.Size = new System.Drawing.Size(200, 100);
            this.gpbNumeroDeParcelas.TabIndex = 3;
            this.gpbNumeroDeParcelas.TabStop = false;
            this.gpbNumeroDeParcelas.Text = "Numero de Parcelas";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Image = ((System.Drawing.Image)(resources.GetObject("btnSubtrair.Image")));
            this.btnSubtrair.Location = new System.Drawing.Point(147, 55);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(37, 39);
            this.btnSubtrair.TabIndex = 3;
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(147, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(37, 39);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtNumeroDeParcelas
            // 
            this.txtNumeroDeParcelas.BackColor = System.Drawing.Color.White;
            this.txtNumeroDeParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDeParcelas.Location = new System.Drawing.Point(6, 37);
            this.txtNumeroDeParcelas.MaxLength = 2;
            this.txtNumeroDeParcelas.Name = "txtNumeroDeParcelas";
            this.txtNumeroDeParcelas.ReadOnly = true;
            this.txtNumeroDeParcelas.Size = new System.Drawing.Size(135, 38);
            this.txtNumeroDeParcelas.TabIndex = 2;
            this.txtNumeroDeParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroDeParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDeParcelas_KeyPress);
            // 
            // gpbTipoDePagamento
            // 
            this.gpbTipoDePagamento.Controls.Add(this.cbbTipoDePagamento);
            this.gpbTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoDePagamento.Location = new System.Drawing.Point(12, 164);
            this.gpbTipoDePagamento.Name = "gpbTipoDePagamento";
            this.gpbTipoDePagamento.Size = new System.Drawing.Size(417, 65);
            this.gpbTipoDePagamento.TabIndex = 10;
            this.gpbTipoDePagamento.TabStop = false;
            this.gpbTipoDePagamento.Text = "Tipo de pagamento";
            // 
            // cbbTipoDePagamento
            // 
            this.cbbTipoDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoDePagamento.FormattingEnabled = true;
            this.cbbTipoDePagamento.Location = new System.Drawing.Point(6, 20);
            this.cbbTipoDePagamento.Name = "cbbTipoDePagamento";
            this.cbbTipoDePagamento.Size = new System.Drawing.Size(405, 39);
            this.cbbTipoDePagamento.TabIndex = 7;
            this.cbbTipoDePagamento.TabStop = false;
            this.cbbTipoDePagamento.SelectedIndexChanged += new System.EventHandler(this.cbbTipoDePagamento_SelectedIndexChanged);
            // 
            // gpbGerarTroco
            // 
            this.gpbGerarTroco.Controls.Add(this.ptbTroco);
            this.gpbGerarTroco.Controls.Add(this.txtTroco);
            this.gpbGerarTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGerarTroco.Location = new System.Drawing.Point(225, 235);
            this.gpbGerarTroco.Name = "gpbGerarTroco";
            this.gpbGerarTroco.Size = new System.Drawing.Size(204, 72);
            this.gpbGerarTroco.TabIndex = 9;
            this.gpbGerarTroco.TabStop = false;
            this.gpbGerarTroco.Text = "Troco";
            // 
            // ptbTroco
            // 
            this.ptbTroco.Image = ((System.Drawing.Image)(resources.GetObject("ptbTroco.Image")));
            this.ptbTroco.Location = new System.Drawing.Point(6, 21);
            this.ptbTroco.Name = "ptbTroco";
            this.ptbTroco.Size = new System.Drawing.Size(31, 38);
            this.ptbTroco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTroco.TabIndex = 13;
            this.ptbTroco.TabStop = false;
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.Yellow;
            this.txtTroco.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.Black;
            this.txtTroco.Location = new System.Drawing.Point(43, 21);
            this.txtTroco.MaxLength = 20;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(155, 39);
            this.txtTroco.TabIndex = 0;
            this.txtTroco.TabStop = false;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbValorPago
            // 
            this.gpbValorPago.Controls.Add(this.ptbValorTotalPago);
            this.gpbValorPago.Controls.Add(this.txtValorPago);
            this.gpbValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValorPago.Location = new System.Drawing.Point(12, 235);
            this.gpbValorPago.Name = "gpbValorPago";
            this.gpbValorPago.Size = new System.Drawing.Size(210, 72);
            this.gpbValorPago.TabIndex = 8;
            this.gpbValorPago.TabStop = false;
            this.gpbValorPago.Text = "Valor pago pelo cliente";
            // 
            // ptbValorTotalPago
            // 
            this.ptbValorTotalPago.Image = ((System.Drawing.Image)(resources.GetObject("ptbValorTotalPago.Image")));
            this.ptbValorTotalPago.Location = new System.Drawing.Point(5, 21);
            this.ptbValorTotalPago.Name = "ptbValorTotalPago";
            this.ptbValorTotalPago.Size = new System.Drawing.Size(31, 38);
            this.ptbValorTotalPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbValorTotalPago.TabIndex = 13;
            this.ptbValorTotalPago.TabStop = false;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(41, 21);
            this.txtValorPago.MaxLength = 7;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(160, 38);
            this.txtValorPago.TabIndex = 4;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnConcluirVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnConcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluirVenda.Image")));
            this.btnConcluirVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConcluirVenda.Location = new System.Drawing.Point(12, 313);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(210, 63);
            this.btnConcluirVenda.TabIndex = 11;
            this.btnConcluirVenda.Text = "Concluir Venda";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // gpbTotalDaParcela
            // 
            this.gpbTotalDaParcela.Controls.Add(this.lblTotalPorParcela);
            this.gpbTotalDaParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotalDaParcela.Location = new System.Drawing.Point(435, 58);
            this.gpbTotalDaParcela.Name = "gpbTotalDaParcela";
            this.gpbTotalDaParcela.Size = new System.Drawing.Size(200, 315);
            this.gpbTotalDaParcela.TabIndex = 13;
            this.gpbTotalDaParcela.TabStop = false;
            this.gpbTotalDaParcela.Text = "Total da Parcela";
            // 
            // lblTotalPorParcela
            // 
            this.lblTotalPorParcela.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPorParcela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalPorParcela.Location = new System.Drawing.Point(9, 17);
            this.lblTotalPorParcela.Name = "lblTotalPorParcela";
            this.lblTotalPorParcela.Size = new System.Drawing.Size(181, 295);
            this.lblTotalPorParcela.TabIndex = 8;
            this.lblTotalPorParcela.Text = "00 R$";
            this.lblTotalPorParcela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbTotalDaVenda
            // 
            this.gpbTotalDaVenda.Controls.Add(this.lblTotalDaComanda);
            this.gpbTotalDaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotalDaVenda.Location = new System.Drawing.Point(228, 313);
            this.gpbTotalDaVenda.Name = "gpbTotalDaVenda";
            this.gpbTotalDaVenda.Size = new System.Drawing.Size(200, 63);
            this.gpbTotalDaVenda.TabIndex = 14;
            this.gpbTotalDaVenda.TabStop = false;
            this.gpbTotalDaVenda.Text = "Preço Total da Comanda";
            // 
            // lblTotalDaComanda
            // 
            this.lblTotalDaComanda.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDaComanda.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDaComanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalDaComanda.Location = new System.Drawing.Point(23, 18);
            this.lblTotalDaComanda.Name = "lblTotalDaComanda";
            this.lblTotalDaComanda.Size = new System.Drawing.Size(153, 42);
            this.lblTotalDaComanda.TabIndex = 15;
            this.lblTotalDaComanda.Text = "00 R$";
            this.lblTotalDaComanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuCaixa
            // 
            this.MenuCaixa.AllowMerge = false;
            this.MenuCaixa.AutoSize = false;
            this.MenuCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuCaixa.GripMargin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.MenuCaixa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOperacoes,
            this.lblValorCaixa});
            this.MenuCaixa.Location = new System.Drawing.Point(0, 0);
            this.MenuCaixa.Name = "MenuCaixa";
            this.MenuCaixa.Size = new System.Drawing.Size(656, 35);
            this.MenuCaixa.TabIndex = 15;
            this.MenuCaixa.TabStop = true;
            this.MenuCaixa.Text = "Menu";
            // 
            // menuOperacoes
            // 
            this.menuOperacoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuOperacoes.BackColor = System.Drawing.Color.LightGray;
            this.menuOperacoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuOperacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMudarParcelas,
            this.btnAbrirCaixa,
            this.btnSair});
            this.menuOperacoes.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOperacoes.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.menuOperacoes.Name = "menuOperacoes";
            this.menuOperacoes.Size = new System.Drawing.Size(148, 31);
            this.menuOperacoes.Text = "Operações extras";
            this.menuOperacoes.ToolTipText = "Operações extras\r\n";
            // 
            // btnMudarParcelas
            // 
            this.btnMudarParcelas.Name = "btnMudarParcelas";
            this.btnMudarParcelas.Size = new System.Drawing.Size(190, 22);
            this.btnMudarParcelas.Text = "Mudar Parcelas";
            this.btnMudarParcelas.Click += new System.EventHandler(this.btnMudarParcelas_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(190, 22);
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // lblValorCaixa
            // 
            this.lblValorCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblValorCaixa.Enabled = false;
            this.lblValorCaixa.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCaixa.ForeColor = System.Drawing.Color.Black;
            this.lblValorCaixa.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblValorCaixa.Name = "lblValorCaixa";
            this.lblValorCaixa.Size = new System.Drawing.Size(129, 31);
            this.lblValorCaixa.Text = "Valor no Caixa ";
            this.lblValorCaixa.ToolTipText = "Calculadora\r\n";
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(190, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmDividirComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(656, 391);
            this.Controls.Add(this.MenuCaixa);
            this.Controls.Add(this.gpbTotalDaVenda);
            this.Controls.Add(this.gpbTotalDaParcela);
            this.Controls.Add(this.gpbTipoDePagamento);
            this.Controls.Add(this.gpbGerarTroco);
            this.Controls.Add(this.gpbValorPago);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.gpbNumeroDeParcelas);
            this.Controls.Add(this.gpbGerarParcelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDividirComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dividir Comanda";
            this.Load += new System.EventHandler(this.frmDividirComanda_Load);
            this.gpbGerarParcelas.ResumeLayout(false);
            this.gpbNumeroDeParcelas.ResumeLayout(false);
            this.gpbNumeroDeParcelas.PerformLayout();
            this.gpbTipoDePagamento.ResumeLayout(false);
            this.gpbGerarTroco.ResumeLayout(false);
            this.gpbGerarTroco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTroco)).EndInit();
            this.gpbValorPago.ResumeLayout(false);
            this.gpbValorPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbValorTotalPago)).EndInit();
            this.gpbTotalDaParcela.ResumeLayout(false);
            this.gpbTotalDaVenda.ResumeLayout(false);
            this.MenuCaixa.ResumeLayout(false);
            this.MenuCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.GroupBox gpbGerarParcelas;
        private System.Windows.Forms.GroupBox gpbNumeroDeParcelas;
        private System.Windows.Forms.TextBox txtNumeroDeParcelas;
        private System.Windows.Forms.GroupBox gpbTipoDePagamento;
        private System.Windows.Forms.ComboBox cbbTipoDePagamento;
        private System.Windows.Forms.GroupBox gpbGerarTroco;
        private System.Windows.Forms.PictureBox ptbTroco;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.GroupBox gpbValorPago;
        private System.Windows.Forms.PictureBox ptbValorTotalPago;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gpbTotalDaParcela;
        private System.Windows.Forms.Label lblTotalPorParcela;
        private System.Windows.Forms.GroupBox gpbTotalDaVenda;
        private System.Windows.Forms.Label lblTotalDaComanda;
        private System.Windows.Forms.MenuStrip MenuCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuOperacoes;
        private System.Windows.Forms.ToolStripMenuItem btnAbrirCaixa;
        private System.Windows.Forms.ToolStripMenuItem lblValorCaixa;
        private System.Windows.Forms.ToolStripMenuItem btnMudarParcelas;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
    }
}